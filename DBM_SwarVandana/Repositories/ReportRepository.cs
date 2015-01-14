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

        public DataSet GetStudentsAttendenceEnrollmentId(long EnrollmentId,long StudentId)
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

        public DataSet GetTe_to_PE_Details()
        {
            string Query = "select (select Description from [dbo].[Sources] where SourceId=a.SourceId) SourceId,a.Name,a.ContactNumber,convert(varchar,a.DateOfEnquiry,106)DateOfEnquiry,(select Description from [dbo].[Disciplines] where DisciplineId=a.Discipline) Discipline,(select FirstName+' '+LastName from [dbo].[Users] where UserId=a.AttendedBy) AttendedBy from [dbo].[Enquiries] a,[Enquiries] b where a.TelephonicEnquiryId=b.EnquiryNumber and a.CentreId=" + SessionWrapper.User.CentreId + "";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
        }

        public DataSet GetPE_to_Enrollment_Details()
        {
            string Query = "select convert(varchar,SE.CreatedDate,106) CDate,(select Description from [dbo].[Disciplines] where DisciplineId=SE.DisciplineId)DisciplineId,convert(varchar,SE.SatrtDate,106)SatrtDate,convert(varchar,SE.EndDate,106)EndDate,EN.Name,EN.ContactNumber,SE.NoOfClasses from [dbo].[StudentEnrollment] SE,[dbo].[Enquiries] EN where SE.EnqueryNo=EN.EnquiryNumber and EN.CentreID=" + SessionWrapper.User.CentreId + "";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
        }

        public DataSet GetDemo_to_Enrollment_Details()
        {
            string Query = "select convert(varchar,SE.CreatedDate,106) CDate,(select Description from [dbo].[Disciplines] where DisciplineId=SE.DisciplineId)DisciplineId,convert(varchar,SE.SatrtDate,106)SatrtDate,convert(varchar,SE.EndDate,106)EndDate,EN.Name,EN.ContactNumber,SE.NoOfClasses,(select NameOfFaculty from [dbo].[Faculties] where FacultyId=EN.FacultyId) FacultyId from [dbo].[StudentEnrollment] SE,[dbo].[Enquiries] EN where SE.EnqueryNo=EN.EnquiryNumber and EN.CentreID=" + SessionWrapper.User.CentreId + " and EN.Demo=1";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return d;
        }
    }
}