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

        public List<ClassDetails> ListClassDetails(int centerId,out int TotalPages, int PageNumber = 1, string search = "")
        {
            int RowsPerPage = ConfigurationWrapper.PageSize;
            SqlParameter[] spParameter = new SqlParameter[6];
            var pcenterId = new SqlParameter("@CenterId", centerId);            
            var rowsPerpage = new SqlParameter("@RowsPerPage", RowsPerPage);
            var rowNo = new SqlParameter("@PageNumber", PageNumber);
            var total = new SqlParameter("@TotalPages", 0) { Direction = System.Data.ParameterDirection.Output };
            var psearch = new SqlParameter("@search", search);
            SqlCommand cmd = new SqlCommand("GetClassDetails", db.GetConnection());
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
                return new List<ClassDetails>();
            else
                return ds.Tables[0].TableToList<ClassDetails>();

            //string Query = @"select ClassId,ClassName,DisciplineId,FacultyId,StudentLimit,StartDate,EndDate,CentreId,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive,IsDeleted  from [dbo].[ClassDetails] where IsDeleted=0 and isactive=1 and CentreId =" + centerId + " AND(ClassName LIKE '%"+  Search +"%' OR DisciplineId IN (SELECT DisciplineId FROM [dbo].[Disciplines] WHERE Discipline LIKE'%" + Search + "%'))";
            //DataSet d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            //if (d != null)
            //    return d.Tables[0].TableToList<ClassDetails>();
            //else
            //    return new List<ClassDetails>();
        }

        public List<ClassDetails> GetAllClasses(int centerId, string Search = "")
        {
            string Query = @"select ClassId,ClassName,DisciplineId,FacultyId,StudentLimit,StartDate,EndDate,CentreId,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive,IsDeleted  from [dbo].[ClassDetails] where IsDeleted=0 and isactive=1 and CentreId =" + centerId + " AND(ClassName LIKE '%" + Search + "%' OR DisciplineId IN (SELECT DisciplineId FROM [dbo].[Disciplines] WHERE Discipline LIKE'%" + Search + "%'))";
            DataSet d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d != null)
                return d.Tables[0].TableToList<ClassDetails>();
            else
                return new List<ClassDetails>();
        }

        public List<ClassDetails> GetClassByWeekDays(int centerId, int weekDay)
        {
            string Query = "SELECT ClassId,ClassName,DisciplineId,FacultyId,StudentLimit,StartDate,EndDate,CentreId,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive,IsDeleted FROM [dbo].[ClassDetails] WHERE CentreId = " + centerId + " and IsDeleted=0 and isactive=1 AND ClassId IN(SELECT ClassId from  [dbo].[ClassTimingPatterns] WHERE WeekDayId = " + weekDay + ")";
            DataSet d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d != null)
                return d.Tables[0].TableToList<ClassDetails>();
            else
                return new List<ClassDetails>();
        }

        public ClassDetails FindById(long ClassId)
        {
            string Query = "SELECT ClassId,ClassName,DisciplineId,FacultyId,StudentLimit,StartDate,EndDate,CentreId,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive,IsDeleted FROM [dbo].[Classdetails] WHERE ClassId = " + ClassId;
            DataSet d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);

            if (d != null)
                return d.Tables[0].TableToList<ClassDetails>().FirstOrDefault();
            else
                return new ClassDetails();

        }
    }
}