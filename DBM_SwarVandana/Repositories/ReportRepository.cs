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
            string Query = "select convert(varchar,DateOfAttendence,106) DateOfAttendence,AttendenceStatus from [dbo].[StudentAttendence] where StuentId=" + StudentId + " and EnrollmentId=" + EnrollmentId + "";
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
    }
}