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
        public List<Students> GetStudents(int centerId, out int TotalPages, int PageNumber, string search)
        {
            int RowsPerPage = ConfigurationWrapper.PageSize;
            SqlParameter[] spParameter = new SqlParameter[6];
            var pcenterId = new SqlParameter("@centerId", centerId);
            var rowsPerpage = new SqlParameter("@RowsPerPage", RowsPerPage);
            var rowNo = new SqlParameter("@PageNumber", PageNumber);
            var total = new SqlParameter("@TotalPages", 0) { Direction = System.Data.ParameterDirection.Output };
            var psearch = new SqlParameter("@search", search);
            SqlCommand cmd = new SqlCommand("[GetStudents]", db.GetConnection());
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
                return new List<Students>();
            else
                return ds.Tables[0].TableToList<Students>();

            //object[] objParam = { centerId, Search };
            //DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetStudents, objParam);
            //if (ds == null)
            //    return new List<Students>();
            //else
            //    return ds.Tables[0].TableToList<Students>();
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
            string Query = "SELECT S.StudentId,S.UniqueKey,S.Name,S.CenterId,S.DOB,S.Contact1,S.EmailAddress,S.Address,S.GuardianName,S.HasTransportFacility,(select Discipline from Disciplines where Disciplineid=E.DisciplineId) as Disciplines,(Select ClassName from ClassDetails where ClassId=E.ClassId) as Class,E.NoOfClasses,E.CourseAmount,E.AmountPaid,E.RegistratonAmount,E.EnrollmentID" +
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
        public DataSet GetClassesForPayments(int studentId, int centreId)
        {
            string Query = "select S.EnrollmentId,S.DisciplineId,D.Discipline from [dbo].[StudentEnrollment] S,[dbo].[Disciplines] D where D.CentreID=" + centreId + " and S.StudentId=" + studentId + " and S.DisciplineId=D.DisciplineId and (S.CourseAmount -(S.RegistratonAmount+S.AmountPaid))>0";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
        }
        public DataSet GetAllDiscliplineForStudents(int studentId, int centreId)
        {
            string Query = "select S.EnrollmentId,S.DisciplineId,D.Discipline from [dbo].[StudentEnrollment] S,[dbo].[Disciplines] D where D.CentreID=" + centreId + " and S.StudentId=" + studentId + " and S.DisciplineId=D.DisciplineId";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
        }
        public DataSet GetDisciplinePaymentDetails(int disciplineId, int studentId, long enrollmentId)
        {
            string Query = "select NoOfClasses,CourseAmount,(RegistratonAmount+AmountPaid) AS PaidAmount,(CourseAmount-(RegistratonAmount+AmountPaid)) AS BalanceAmount,SatrtDate,EndDate from [dbo].[StudentEnrollment] where DisciplineId=" + disciplineId + " and StudentId=" + studentId + " and EnrollmentId=" + enrollmentId + "";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
        }
        public int SaveStudentPayments(PaymentDetails pd, string disciplineId)
        {
            int DisciplineId = Convert.ToInt32(disciplineId);
            object[] objParam = { pd.StudentId, pd.BankName, pd.PaymentMode, pd.TransactionDetails, pd.DateOfPayment, pd.AmountPaid, pd.DueDate, pd.AddBy, pd.AddDate, pd.ModifyBy, pd.ModifyDate, DisciplineId,pd.EnrollmentId };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), "InsertPaymentDetails", objParam);
            return Convert.ToInt32(d);
        }
        public int EnrollStudents(StudentEnrollment se)
        {
            object[] objParam = { se.ActionId, se.EnrollmentId, se.StudentId, se.DisciplineId,se.CourseAmount,se.RegistratonAmount,se.NoOfClasses, 
                                    se.AmountPaid,se.SatrtDate,se.EndDate, se.CreatedDate,se.CreatedBy,se.ModifyDate,se.ModifBy,se.IsActive,se.IsDeleted,se.BankName,se.PaymentMode,se.PaymentDetails,se.DueDate,se.EnqueryNo,se.IsRenewal,se.Remark};
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_StudentEntrollment_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Students> GetStudentsByDisciplane(long displaneId, long batchId, int weekDay,DateTime AttendenceDate)
        {
            string Query = "SELECT s.StudentId, s.Name , e.EnrollmentId FROM [dbo].[student] s , [dbo].[StudentEnrollment] e  WHERE s.StudentId= e.StudentId and  DisciplineId = " + displaneId + "  and SatrtDate <='"+AttendenceDate.Date+"'"
                            + " and s.StudentId IN(SELECT en.StudentId FROM [dbo].[StudentEnrollment] en WHERE EnrollmentId IN (SELECT EnrollmentId FROM [dbo].[StudentBatchMapping] WHERE BatchId =" + batchId + "))";

            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d == null)
                return new List<Students>();
            else
                return d.Tables[0].TableToList<Students>();
        }

        public List<StudentEnrollment> GetStudentDetails(long studentId)
        {
            string Query = "select e.StudentID,(select Name from student where StudentID=e.StudentID) as StudentName,e.DisciplineID,e.NoOfClasses,e.SatrtDate,e.EndDate,e.RegistratonAmount,e.CourseAmount,e.AmountPaid" +
                           ",(e.CourseAmount-(e.AmountPaid+e.RegistratonAmount)) as PendingAmount" +
                           ",(select count(*)  from studentattendence  where enrollmentId=e.enrollmentId and  Attendencestatus= 1) as Presents" +
                           ",(select count(*)  from studentattendence  where enrollmentId=e.enrollmentId and Attendencestatus= 2) as Absents" +
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

        public DataTable GetEndDate(DateTime startDate, int NoofClass, string Batches, long centerId)
        {
            object[] Obj = { startDate, NoofClass, Batches, centerId };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), "GetEndClassDate", Obj);
            if (d == null)
                return new DataTable();
            else
                return d.Tables[0];
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

        public List<StudentAttendence> GetClassAttendence(long batchId, DateTime dateofAttendence)
        {
            string Query = "SELECT Id,BatchId,EnrollmentId,StuentId,AttendenceStatus,DateOfAttendence,AddDate,AddBy,ModifyDate,ModifyBy FROM [dbo].[StudentAttendence]" +
                            "WHERE BatchId =" + batchId + " AND CONVERT(VARCHAR(10),DateOfAttendence,106)= CONVERT(VARCHAR(10),'" + dateofAttendence + "',106)";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d == null)
                return new List<StudentAttendence>();
            else
                return d.Tables[0].TableToList<StudentAttendence>();
        }

        public List<StudentRenewal> RenewStudentList(int centerId, string search = "")
        {
            bool IsStatus = false;
            switch (search.ToLower())
            {
                case "red":
                    search = "1";
                    IsStatus = true;
                    break;
                case "green":
                    search = "2";
                    IsStatus = true;
                    break;
                case "yellow":
                    search = "3";
                    IsStatus = true;
                    break;
                default:
                    break;
            }
            string Query = string.Empty;
            if (IsStatus == false)
            {
                Query = "select SR.RenewalId,SR.EnrollmentNo,(select name from student where studentid=SR.StudentId) AS Name,FT.NameOfFaculty AS Faculty,SR.AddDate,SR.Description,SR.Remark,SR.Status from [dbo].[StudentRenewal] SR,Faculties FT" +
                           " WHERE SR.FacultyId=FT.FacultyId AND (FT.NameOfFaculty like '%" + search + "%' OR SR.Description like '%" + search + "%' OR SR.Remark like '%" + search + "%')";
            }
            else
            {
                Query = "  select SR.RenewalId,SR.EnrollmentNo,(select name from student where studentid=SR.StudentId) AS Name,FT.NameOfFaculty AS Faculty,SR.AddDate,SR.Description,SR.Remark,SR.Status from [dbo].[StudentRenewal] SR,Faculties FT" +
                        " WHERE SR.FacultyId=FT.FacultyId AND SR.Status=" + search + "";
            }
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (ds == null)
                return new List<StudentRenewal>();
            else
                return ds.Tables[0].TableToList<StudentRenewal>();
        }

        public StudentRenewal GetRenewStudentFromRenewId(int centerId, long renewId)
        {
            StudentRenewal sr = new StudentRenewal();
            string Query = "select RenewalId,EnrollmentNo,StudentId,FacultyId,AddDate,Description,Remark,Status from [dbo].[StudentRenewal]  WHERE RenewalId=" + renewId + " and CenterId=" + centerId + "";
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (ds == null)
                return sr;
            else
                return ds.Tables[0].TableToList<StudentRenewal>().FirstOrDefault();
        }

        public int RenewalStudents(StudentRenewal sr)
        {
            try
            {
                object[] objParam = { sr.ActionId, sr.RenewalId, sr.EnrollmentNo, sr.StudentId, sr.FacultyId, sr.AddDate, sr.Description, sr.Remark, sr.Status, sr.CenterId, sr.AddedBy, sr.ModifyBy, sr.ModifyDate };
                var d = SqlHelper.ExecuteScalar(db.GetConnection(), "USP_StudentRenewal_IUD", objParam);
                return Convert.ToInt32(d);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        #region Student Remarks

        public Students GetStudentByStudentId(Int64 StudentId)
        {
            var Query = "select Name,UniqueKey from [Student] where StudentId=" + StudentId;
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d.Tables[0].TableToList<Students>().FirstOrDefault();
        }

        public int InsertStudentRemarks(StudentRemarks sr)
        {
            object[] objParam = {sr.ActionID,sr.RemarksID,sr.FacultyID,sr.StudentId,sr.Remarks,sr.DateOfRemarks,sr.CentreID,sr.CreatedOn,sr.CreatedBy,
                                    sr.ModifiedOn,sr.ModifiedBy,sr.IsActive,sr.IsDeleted };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.InsertStudentRemarks, objParam);
            return Convert.ToInt32(d);
        }

        public List<StudentRemarks> GetStudentRemarksByCentreID(int CentreID, out int TotalPages, int page, string search)
        {
            int RowsPerPage = ConfigurationWrapper.PageSize;
            SqlParameter[] spParameter = new SqlParameter[6];
            var pcenterId = new SqlParameter("@CentreID", CentreID);
            var rowsPerpage = new SqlParameter("@RowsPerPage", RowsPerPage);
            var rowNo = new SqlParameter("@PageNumber", page);
            var total = new SqlParameter("@TotalPages", 0) { Direction = System.Data.ParameterDirection.Output };
            var psearch = new SqlParameter("@search", search);
            SqlCommand cmd = new SqlCommand("[GetStudentRemarksByCentreId]", db.GetConnection());
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
                return new List<StudentRemarks>();
            else
                return ds.Tables[0].TableToList<StudentRemarks>();

            //var ds = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetStudentRemarksByCentreId, CentreID, search);
            //if (ds == null)
            //    return new List<StudentRemarks>();
            //else
            //    return ds.Tables[0].TableToList<StudentRemarks>();
        }

        public StudentRemarks GetStudentRemarksByRemarksID(Int64 RemarksID)
        {
            var ds = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetStudentRemarksByRemarksID, RemarksID);
            if (ds == null)
                return new StudentRemarks();
            else
                return ds.Tables[0].TableToList<StudentRemarks>().FirstOrDefault();
        }

        #endregion

    }
}