﻿using System;
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
            object[] objParam = { u.ActionId, u.UserId,
                                    u.FirstName, u.LastName, u.DOB, u.DOJ, u.ContactNumber, 
                                    u.EmailID, u.CentreId, u.Salary, u.RoleId, u.UserName, 
                                    u.Password, u.Address, u.StateId, u.CityId, u.AddDate, 
                                    u.AddedBy, u.ModifyDate, u.ModifyBy, u.IsActive };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Users_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Centres> GetAllCentres(string search = "")
        {
            object[] objParam = { search };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_CentresGetAll, objParam);
            return ConvertList.TableToList<Centres>(d.Tables[0]);
        }

        public List<Users> GetAllUsers(long centerId, string search = "")
        {
            object[] objParam = { centerId, search };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_UsersGetAll, objParam);
            if (d != null)
                return ConvertList.TableToList<Users>(d.Tables[0]);
            else return new List<Users>();
        }

    }
}