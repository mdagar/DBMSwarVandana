using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBConnection;
using System.Data;
using System.Data.SqlClient;
using SqlRepositories;
using Code;

namespace Repositories
{
    public class ReportRepository
    {
        DBConnections db = new DBConnections();

        public DataSet GetStudentsAttendenceEnrollmentId(long EnrollmentId, long StudentId)
        {
            string Query = "select convert(varchar,DateOfAttendence,106) DateOfAttendence,(select Timming from [dbo].[Batches]  where BatchId=SA.BatchId) Timming,AttendenceStatus from [dbo].[StudentAttendence] SA where StuentId=" + StudentId + " and EnrollmentId=" + EnrollmentId + "";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
        }

        public DataSet GetStudentsPaymentDetails(long EnrollmentId, long StudentId)
        {
            object[] Obj = { EnrollmentId, StudentId };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), "GetPaymentDetailsReportData", Obj);
            if (d == null)
                return new DataSet();
            else
                return d;
        }

        public DataSet GetTe_to_PE_Details(DateTime fromdate, DateTime todate)
        {
            string Query = "select (select Description from [dbo].[Sources] where SourceId=a.SourceId) SourceId,a.Name,a.ContactNumber,convert(varchar,a.DateOfEnquiry,106)DateOfEnquiry,(select Description from [dbo].[Disciplines] where DisciplineId=a.Discipline) Discipline,(select FirstName+' '+LastName from [dbo].[Users] where UserId=a.AttendedBy) AttendedBy,a.TelephonicEnquiryId,a.EnquiryNumber from [dbo].[Enquiries] a,[Enquiries] b where a.TelephonicEnquiryId=b.EnquiryNumber and a.CentreId=" + SessionWrapper.User.CentreId + " and a.DateOfEnquiry between '" + fromdate + "' and '" + todate + "'";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
        }

        public DataSet GetPE_to_Enrollment_Details(DateTime fromdate, DateTime todate)
        {
            string Query = "select convert(varchar,SE.CreatedDate,106) CDate,(select Description from [dbo].[Disciplines] where DisciplineId=SE.DisciplineId)DisciplineId,convert(varchar,SE.SatrtDate,106)SatrtDate,convert(varchar,SE.EndDate,106)EndDate,EN.Name,EN.ContactNumber,SE.NoOfClasses,EN.EnquiryNumber from [dbo].[StudentEnrollment] SE,[dbo].[Enquiries] EN where SE.EnqueryNo=EN.EnquiryNumber and EN.CentreID=" + SessionWrapper.User.CentreId + " and SE.CreatedDate  between '" + fromdate + "' and '" + todate + "' and SE.IsRenewal=0";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
        }

        public DataSet GetDemo_to_Enrollment_Details(DateTime fromdate, DateTime todate)
        {
            string Query = "select convert(varchar,SE.CreatedDate,106) CDate,(select Description from [dbo].[Disciplines] where DisciplineId=SE.DisciplineId)DisciplineId,convert(varchar,SE.SatrtDate,106)SatrtDate,convert(varchar,SE.EndDate,106)EndDate,EN.Name,EN.ContactNumber,SE.NoOfClasses,(select NameOfFaculty from [dbo].[Faculties] where FacultyId=EN.FacultyId) FacultyId from [dbo].[StudentEnrollment] SE,[dbo].[Enquiries] EN where SE.EnqueryNo=EN.EnquiryNumber and EN.CentreID=" + SessionWrapper.User.CentreId + " and EN.Demo=1 and SE.CreatedDate  between '" + fromdate + "' and '" + todate + "' and SE.IsRenewal=0";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
        }
        public DataSet GetStudentEnrollmentList(DateTime fromdate, DateTime todate, int datefilter, out int TotalPages, out decimal TotalAmount, int PageNumber)
        {
            int RowsPerPage = ConfigurationWrapper.PageSize;
            SqlParameter[] spParameter = new SqlParameter[8];
            var pcenterId = new SqlParameter("@centerId", SessionWrapper.User.CentreId);
            var rowsPerpage = new SqlParameter("@RowsPerPage", RowsPerPage);
            var rowNo = new SqlParameter("@PageNumber", PageNumber);            
            var fdate = new SqlParameter("@fromdate", fromdate);
            var tdate = new SqlParameter("@todate", todate);
            var dfilter = new SqlParameter("@datefilter", datefilter);
            var total = new SqlParameter("@TotalPages", 0) { Direction = System.Data.ParameterDirection.Output };
            var totalAmount = new SqlParameter("@SumAmount", 0) { Direction = System.Data.ParameterDirection.Output };
            
            SqlCommand cmd = new SqlCommand("[GetEnrollmentDetailsList]", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            cmd.Parameters.Add(pcenterId);
            cmd.Parameters.Add(rowsPerpage);
            cmd.Parameters.Add(rowNo);
            cmd.Parameters.Add(total);
            cmd.Parameters.Add(fdate);
            cmd.Parameters.Add(tdate);
            cmd.Parameters.Add(dfilter);
            cmd.Parameters.Add(totalAmount);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            TotalPages = Convert.ToInt32(total.Value);
            TotalAmount = Convert.ToDecimal(totalAmount.Value);
            return ds;
        }

        public DataSet GetUpCommingPaymentDetail(int month)
        {
            string Query = string.Empty;
            if (month != 0)
                Query = "with t as(select ST.Name,ST.UniqueKey,(select Discipline from [dbo].[Disciplines] where DisciplineId=SE.DisciplineId) as Discipline,(SE.CourseAmount-(SE.RegistratonAmount+SE.AmountPaid)) as Balance,(select convert(varchar,Duedate,106) from [dbo].[PaymentDetails] where paymentid=(select max(paymentid) from [dbo].[PaymentDetails] where enrollmentid=SE.enrollmentid) ) as DueDate from [dbo].[StudentEnrollment] SE,Student ST Where (SE.CourseAmount-(SE.RegistratonAmount+SE.AmountPaid))>0 and SE.StudentId=ST.StudentId and ST.CenterId=" + SessionWrapper.User.CentreId + " ) select * from t where MONTH(duedate)=" + month + "";
            else
                Query = "with t as(select ST.Name,ST.UniqueKey,(select Discipline from [dbo].[Disciplines] where DisciplineId=SE.DisciplineId) as Discipline,(SE.CourseAmount-(SE.RegistratonAmount+SE.AmountPaid)) as Balance,(select convert(varchar,Duedate,106) from [dbo].[PaymentDetails] where paymentid=(select max(paymentid) from [dbo].[PaymentDetails] where enrollmentid=SE.enrollmentid) ) as DueDate from [dbo].[StudentEnrollment] SE,Student ST Where (SE.CourseAmount-(SE.RegistratonAmount+SE.AmountPaid))>0 and SE.StudentId=ST.StudentId and ST.CenterId=" + SessionWrapper.User.CentreId + " ) select * from t ";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
        }
    }
}