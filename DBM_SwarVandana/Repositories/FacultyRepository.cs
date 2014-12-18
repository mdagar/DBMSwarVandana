using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBConnection;
using DBM_SwarVandana.Resources;
using Models;
using System.Reflection;
using SqlRepositories;
using ListConversion;
using Code;
using System.Data;
using System.Data.SqlClient;

namespace Repositories
{
    public class FacultyRepository : Faculties
    {
        DBConnections db = new DBConnections();
        public int FacultyRegistration(Faculties f)
        {
            object[] objParam = { f.ActionId,f.FacultyId,f.NameOfFaculty,f.EmailID,
                                  f. ContactNumber,
                                  f. Address          ,
                                  f. StateId          ,
                                  f. CityId           ,
                                  f. DOJ              ,
                                  f. Gender           ,
                                  f. Salary           ,
                                  f. SalaryRevision   ,
                                  f. DisciplineId     ,
                                  f. YearOfExperience ,
                                  f. CentreId         ,
                                  f. Picture          ,
                                  f. AddDate          ,
                                  f. AddedBy          ,
                                  f. ModifyDate       ,
                                  f. ModifyBy        ,
                                  f. IsActive,f.IsDeleted};
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Faculties_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Faculties> GetFacultyByCentreId(int CentreId, out int TotalPages, int PageNumber = 1, string search = "")
        {
            int RowsPerPage = ConfigurationWrapper.PageSize;
            SqlCommand cmd = new SqlCommand("USP_FacultyGetByCenterId", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            var centerid = new SqlParameter("@CentreID", CentreId);
            var rowsperpage = new SqlParameter("@RowsPerPage", RowsPerPage);
            var Page = new SqlParameter("@PageNumber", PageNumber);
            var total = new SqlParameter("@TotalPages", 0) { Direction = ParameterDirection.Output };
            cmd.Parameters.Add(centerid);
            cmd.Parameters.Add(rowsperpage);
            cmd.Parameters.Add(PageNumber);
            cmd.Parameters.Add(total);            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            TotalPages = Convert.ToInt32(total.Value);
            return ConvertList.TableToList<Faculties>(ds.Tables[0]);
        }

        public List<Faculties> GetAllFacultyByCentreId(int CentreId)
        {
            string Query = "SELECT FacultyId,NameOfFaculty,EmailID,ContactNumber,Address,StateId,CityId,DOJ,Gender,Salary,SalaryRevision,DisciplineId,YearOfExperience,CentreId,Picture,AddDate," +
            "AddedBy,ModifyDate,ModifyBy,IsActive,DOB FROM [dbo].[Faculties] WHERE CentreId = " + CentreId + " AND IsDeleted=0";
            SqlCommand cmd = new SqlCommand(Query, db.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ConvertList.TableToList<Faculties>(ds.Tables[0]);
        }

        public Faculties GetFacultyByFacultyId(long FacultyId)
        {
            string query = "SELECT FacultyId,NameOfFaculty,EmailID,ContactNumber,Address,StateId,CityId,DOJ,Gender,Salary,SalaryRevision,DisciplineId,YearOfExperience,CentreId,Picture,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive FROM [dbo].[Faculties] WHERE FacultyId=" + FacultyId + "";
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, query);
            if (ds == null)
                return new Faculties();
            else
                return ds.Tables[0].TableToList<Faculties>().FirstOrDefault();
        }
        
    }
}