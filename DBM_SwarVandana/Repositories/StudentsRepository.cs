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
    public class StudentsRepository
    {
        DBConnections db = new DBConnections();
        public List<Students> GetStudents(int centerId)
        {
            object[] objParam = { centerId, "" };
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetStudents, objParam);
            if (ds == null)
                return new List<Students>();
            else
                return ds.Tables[0].TableToList<Students>();
        }

        public int AdStudents(Students s)
        {
            object[] objParam = {s.ActionId,s.Id,s.UniqueKey,s.Name,s.CenterId,s.DOB,s.Contact1,s.Contact2,s.EmailAddress,s.Address,s.StateId,
                                    s.CityId,s.GuardianName,s.Occupation,s.HasTransportFacility,s.CreatedDate,s.CreatedBy,s.ModifyDate,s.ModifyBy,s.IsActive,s.IsDeleted };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Students_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public Students GetStudentsByUniqueId(string UniqueId)
        {
            Students st = new Students();
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetStudentsByUniqueId, UniqueId);
            if (d == null)
                return st;
            else
            {
                st.Id = Convert.ToInt32(d.Tables[0].Rows[0][0]);
                st.Name = Convert.ToString(d.Tables[0].Rows[0][2]);
                st.DOB = Convert.ToDateTime(d.Tables[0].Rows[0][4]);
                st.Contact1 = Convert.ToString(d.Tables[0].Rows[0][5]);
                st.Address = Convert.ToString(d.Tables[0].Rows[0][10]);
                st.EmailAddress = Convert.ToString(d.Tables[0].Rows[0][7]);
                st.GuardianName = Convert.ToString(d.Tables[0].Rows[0][11]);
                st.Occupation = Convert.ToString(d.Tables[0].Rows[0][12]);
                return st;
            }
        }

        public List<Students> GetStudentsByCentreId(int CentreId)
        {
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetStudentsByCentreId, CentreId);
            if (d == null)
                return new List<Students>();
            else
                return d.Tables[0].TableToList<Students>();
        }

        public int EnrollStudents(StudentEnrollment se)
        {
            object[] objParam = {  se.ActionId, se.EnrollmentId, se.StudentId, se.DisciplineId,se.ClassId,se.CourseAmount,se.RegistratonAmount,se.NoOfClasses, 
                                    se.AmountPaid,se.SatrtDate,se.EndDate, se.CreatedDate,se.CreatedBy,se.ModifyDate,se.ModifBy,se.IsActive,se.IsDeleted};
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_StudentEntrollment_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Students> GetStudentsByClassId(int ClassId)
        {
            string Query = @"SELECT StudentId,UniqueKey,Name,CenterId,DOB,Contact1,Contact2,EmailAddress,StateId,CityId,Address,GuardianName,Occupation,
                           HasTransportFacility,IsActive,CreatedBy,CreatedDate,ModifyBy,ModifyDate,IsDeleted FROM [dbo].[Student] WHERE StudentId
                           IN(SELECT StudentId FROM [dbo].[StudentEnrollment] WHERE ClassId='" + ClassId + "' AND IsActive =1 AND IsDeleted =0)";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d == null)
                return new List<Students>();
            else
                return d.Tables[0].TableToList<Students>();
        }

        public List<ClassDetails> GetClassByDisciplineId(int DisciplineId)
        {
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetClassByDisciplineId, DisciplineId);
            if (d == null)
                return new List<ClassDetails>();
            else
                return d.Tables[0].TableToList<ClassDetails>();
        }

        public ClassDetails GetClassByClassId(int ClassId)
        {
            ClassDetails cl = new ClassDetails();
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetClassByClassId, ClassId);
            if (d == null)
                return cl;
            else
            {
                cl.ClassId = Convert.ToInt32(d.Tables[0].Rows[0][0]);
                cl.ClassName = Convert.ToString(d.Tables[0].Rows[0][1]);
                cl.ClassName = Convert.ToString(d.Tables[0].Rows[0][2]);
                cl.StudentLimit = Convert.ToInt32(d.Tables[0].Rows[0][3]);
                cl.StartDate = Convert.ToDateTime(d.Tables[0].Rows[0][4]);
                cl.EndDate = Convert.ToDateTime(d.Tables[0].Rows[0][5]);
                return cl;
            }
        }

    }
}