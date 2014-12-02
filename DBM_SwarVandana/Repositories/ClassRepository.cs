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

namespace Repositories
{
    public class ClassRepository
    {
        DBConnections db = new DBConnections();
        public int CreateClassDetails(ClassDetails cls)
        {
            object[] objParam = { cls.ActionId, cls.ClassId, cls.DisciplineId, cls.FacultyId, cls.StartDate, 
                                    cls.EndDate, cls.CentreId, cls.AddDate, cls.AddedBy, cls.ModifyDate, cls.ModifyBy, cls.IsActive };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_ClassDetails_IUD, objParam);
            return Convert.ToInt32(d);
        }
    }
}