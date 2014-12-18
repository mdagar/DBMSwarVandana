using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DBConnection;
using DBM_SwarVandana.Resources;
using Models;
using System.Reflection;
using SqlRepositories;
using ListConversion;
using Code;
using System.Data.SqlClient;

namespace Repositories
{

    public class UsersRepository
    {
        DBConnections db = new DBConnections();
        public List<Users> Login(string login, string password)
        {
            object[] objParam = { login, password };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_LoginCheck, objParam);
            if (d.Tables[0].Rows.Count > 0)
            {
                CookieWrapper.UniqueId = Convert.ToInt32(d.Tables[0].Rows[0][0]);

                return ConvertList.TableToList<Users>(d.Tables[0]);
            }
            else
                throw new Exception(Messages.InvalidLogin);
        }

        public Users UsersGetByUserId(long UserId)
        {
            object[] objParam = { UserId };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_UsersGetByUserId, objParam);
            if (d != null)
                return ConvertList.TableToList<Users>(d.Tables[0]).FirstOrDefault();
            else return new Users();
        }

        public int ChangePassword(int UserId, string CurrentPassword, string Password)
        {
            object[] objParam = { UserId, CurrentPassword, Password };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_ChangePassword, objParam);
            return Convert.ToInt32(d);
        }

        public int CreateUsers(Users u)
        {
            if (u.UserId > 0)
                u.ActionId = 1;
            else
                u.ActionId = 0;
            object[] objParam = { u.ActionId, u.UserId,
                                    u.FirstName, u.LastName, u.DOB, u.DOJ, u.ContactNumber, 
                                    u.EmailID, u.CentreId, u.Salary, u.RoleId, u.UserName, 
                                    u.Password, u.Address, u.StateId, u.CityId, u.AddDate, 
                                    u.AddedBy, u.ModifyDate, u.ModifyBy, u.IsActive,u.IsDeleted };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Users_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Centres> GetAllCentres(string search = "")
        {
            object[] objParam = { search };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_CentresGetAll, objParam);
            return ConvertList.TableToList<Centres>(d.Tables[0]);
        }

        public List<Users> GetAllUsers(long centerId, out int TotalPages, int PageNumber = 1, string search = "")
        {
            int RowsPerPage = ConfigurationWrapper.PageSize;
            SqlParameter[] spParameter = new SqlParameter[6];
            var pcenterId = new SqlParameter("@centerId", centerId);
            var rowsPerpage = new SqlParameter("@RowsPerPage", RowsPerPage);
            var rowNo = new SqlParameter("@PageNumber", PageNumber);
            var total = new SqlParameter("@TotalPages", 0) { Direction = System.Data.ParameterDirection.Output };
            var psearch = new SqlParameter("@search", search);
            SqlCommand cmd = new SqlCommand(Procedures.USP_UsersGetAll, db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            cmd.Parameters.Add(pcenterId);
            cmd.Parameters.Add(rowsPerpage);
            cmd.Parameters.Add(rowNo);
            cmd.Parameters.Add(total);
            cmd.Parameters.Add(psearch);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            TotalPages = Convert.ToInt32(total.Value);
            if (ds == null)
                return new List<Users>();
            else
                return ds.Tables[0].TableToList<Users>();
        }

        public List<Users> AllUsers(long centerId)
        {
            string Query = "SELECT UserId,FirstName,LastName,DOB,DOJ,ContactNumber,EmailID,CentreId,Salary,RoleId,UserName,Password,StateId,CityId,Address,AddDate,AddedBy,"
                           + "ModifyDate,ModifyBy,IsActive,IsDeleted from [dbo].[Users]"
                           + "where IsActive=1 and isdeleted=0 and CentreId =" + centerId;
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d != null)
                return ConvertList.TableToList<Users>(d.Tables[0]);
            else return new List<Users>();
        }

    }
}