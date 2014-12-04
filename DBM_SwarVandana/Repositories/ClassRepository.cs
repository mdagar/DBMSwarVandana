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

namespace Repositories
{
    public class ClassRepository
    {
        DBConnections db = new DBConnections();
        public int CreateClassDetails(ClassDetails cls)
        {
            object[] objParam = { cls.ActionId, cls.ClassId,cls.ClassName,cls.StudentLimit, cls.DisciplineId, cls.FacultyId, cls.StartDate, 
                                    cls.EndDate, cls.CentreId, cls.AddDate, cls.AddedBy, cls.ModifyDate, cls.ModifyBy, cls.IsActive,cls.IsDeleted };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_ClassDetails_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<ClassDetails> ListClassDetails(int centerId)
        {
            string Query = "select ClassId,ClassName,DisciplineId,FacultyId,StudentLimit,StartDate,EndDate,CentreId,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive,IsDeleted from [dbo].[ClassDetails] where CentreId =" + centerId + "and IsDeleted=0 and isactive=1";

            DataSet d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);

            if (d != null)
                return d.Tables[0].TableToList<ClassDetails>();
            else
                return new List<ClassDetails>();
        }

        public ClassDetails FindById(long ClassId)
        {
            string Query = "SELECT ClassId,DisciplineId,FacultyId,StudentLimit,StartDate,EndDate,CentreId,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive,IsDeleted FROM [dbo].[Classdetails] WHERE ClassId = " + ClassId;
            DataSet d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);

            if (d != null)
                return d.Tables[0].TableToList<ClassDetails>().FirstOrDefault();
            else
                return new ClassDetails();

        }
    }
}