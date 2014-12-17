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
using System.Xml;
using System.Data.SqlClient;
namespace Repositories
{
    public class StudentsRepository
    {
        DBConnections db = new DBConnections();
        public List<Students> GetStudents(int centerId, string Search = "")
        {
            object[] objParam = { centerId, Search };
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetStudents, objParam);
            if (ds == null)
                return new List<Students>();
            else
                return ds.Tables[0].TableToList<Students>();
        }

        public string AdStudents(Students s)
        {
            object[] objParam = {s.ActionId,s.StudentId,s.UniqueKey,s.Name,s.CenterId,s.DOB,s.Contact1,s.Contact2,s.EmailAddress,s.Address,s.StateId,
                                    s.CityId,s.GuardianName,s.Occupation,s.HasTransportFacility,s.CreatedDate,s.CreatedBy,s.ModifyDate,s.ModifyBy,s.IsActive,s.IsDeleted };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Students_IUD, objParam);
            return Convert.ToString(d);
        }

        public Students GetStudentsByUniqueId(string UniqueId)
        {
            Students st = new Students();
            object[] obj = { UniqueId, SessionWrapper.User.CentreId };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetStudentsByUniqueId, obj);
            if (d == null)
                return st;
            else
                return d.Tables[0].TableToList<Students>().FirstOrDefault();
        }
        public DataSet GetStudentsByEnrollmentId(int EnrollmentId)
        {
            string Query = "SELECT S.StudentId,S.UniqueKey,S.Name,S.CenterId,S.DOB,S.Contact1,S.EmailAddress,S.Address,S.GuardianName,S.HasTransportFacility,(select Discipline from Disciplines where Disciplineid=E.DisciplineId) as Disciplines,(Select ClassName from ClassDetails where ClassId=E.ClassId) as Class,E.NoOfClasses,E.CourseAmount,E.AmountPaid,E.RegistratonAmount" +
                           " FROM [DBMSwarVandana].[dbo].[Student] S,[DBMSwarVandana].[dbo].[StudentEnrollment] E where S.StudentId=E.StudentId and E.EnrollmentID=" + EnrollmentId + "";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
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

        public List<Students> GetStudentsByClassId(long ClassId)
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
            object[] Obj = { DisciplineId, SessionWrapper.User.CentreId };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetClassByDisciplineId, Obj);
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
                cl.FaculityName = Convert.ToString(d.Tables[0].Rows[0][2]);
                cl.StudentLimit = Convert.ToInt32(d.Tables[0].Rows[0][3]);
                cl.StartDate = Convert.ToDateTime(d.Tables[0].Rows[0][4]);
                cl.EndDate = Convert.ToDateTime(d.Tables[0].Rows[0][5]);
                cl.NoOfStudent = Convert.ToInt32(d.Tables[0].Rows[0][7]);
                return cl;
            }
        }

        public List<StudentEnrollment> GetStudentDetails(long studentId)
        {
            string Query = "select e.StudentID,(select Name from student where StudentID=e.StudentID) as StudentName,e.DisciplineID,e.ClassID,e.RegistratonAmount,e.CourseAmount,e.AmountPaid" +
                           ",(e.CourseAmount-(e.AmountPaid+e.RegistratonAmount)) as PendingAmount" +
                           ",(select count(*)  from studentattendence  where stuentid=e.StudentID and classid=e.ClassID and Attendencestatus= 1) as Presents" +
                           ",(select count(*)  from studentattendence  where stuentid=e.StudentID and classid=e.ClassID and Attendencestatus= 2) as Absents" +
                           " from studentenrollment  e where e.StudentID=" + studentId;
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d == null)
                return new List<StudentEnrollment>();
            else
                return d.Tables[0].TableToList<StudentEnrollment>();
        }

        public long SaveAttendence(XmlDocument doc)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertStudentAttendence", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@XMLdata", doc.InnerXml);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
        }

        public long GetRemainingClassesDetails(int classId, DateTime startDate)
        {
            object[] Obj = { classId, startDate };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), "GetRemainingClasses", Obj);
            if (d == null)
                return 0;
            else
                return Convert.ToInt64(d.Tables[0].Rows[0][0]);
        }

        public List<StudentAttendence> GetAttendenceByStudentId(long classId, long studentId, DateTime dateofAttendence)
        {
            string Query = "SELECT Id,ClassId,WeekDayId,StuentId,AttendenceStatus,DateOfAttendence,AddDate,AddBy,ModifyDate,ModifyBy FROM [dbo].[StudentAttendence]" +
                            "WHERE ClassId =" + classId + " AND StuentId =" + studentId + " AND CONVERT(VARCHAR(10),DateOfAttendence,106)= CONVERT(VARCHAR(10)," + dateofAttendence + ",106)";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d == null)
                return new List<StudentAttendence>();
            else
                return d.Tables[0].TableToList<StudentAttendence>();
        }

        public List<StudentAttendence> GetClassAttendence(long classId, DateTime dateofAttendence)
        {
            string Query = "SELECT Id,ClassId,WeekDayId,StuentId,AttendenceStatus,DateOfAttendence,AddDate,AddBy,ModifyDate,ModifyBy FROM [dbo].[StudentAttendence]" +
                            "WHERE ClassId =" + classId + " AND CONVERT(VARCHAR(10),DateOfAttendence,106)= CONVERT(VARCHAR(10)," + dateofAttendence + ",106)";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d == null)
                return new List<StudentAttendence>();
            else
                return d.Tables[0].TableToList<StudentAttendence>();
        }

        public int RenewalStudents(StudentRenewal sr)
        {
            try
            {
                string Query = "Insert into StudentRenewal(EnrollmentId,StudentId,FacultyId,RenewalDate,Description,Remark,Status) values(" + sr.EnrollmentId + "," + sr.StudentId + "," + sr.FacultyId + ",'" + sr.RenewalDate + "','" + sr.Description + "','" + sr.Remark + "','" + sr.Status + "')";
                var d = SqlHelper.ExecuteNonQuery(db.GetConnection(), CommandType.Text, Query);
                return Convert.ToInt32(d);
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

    }
}