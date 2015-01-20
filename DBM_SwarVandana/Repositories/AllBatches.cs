using DBConnection;
using Models;
using SqlRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Code;
using ListConversion;
namespace Repositories
{
    public class AllBatches
    {

        DBConnections db = new DBConnections();

        public List<Batches> FindAllBatches(long CenterId)
        {
            string Query = "select BatchId,Day,Timming,StudentLinit,CreatedBy,CreatedDate,ModifyBy,ModifyDate,CenterId from [dbo].[Batches] where centerid =" + CenterId;
            var ds = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (ds == null)
                return new List<Batches>();
            else
                return ConvertList.TableToList<Batches>(ds.Tables[0]);
        }

        public List<Batches> FindBatchByDayId(long CenterId, int dayId)
        {
            string Query = "select BatchId,Day,Timming,StudentLinit,CreatedBy,CreatedDate,ModifyBy,ModifyDate,CenterId from [dbo].[Batches] where centerid =" + CenterId + " AND Day=" + dayId;
            var ds = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (ds == null)
                return new List<Batches>();
            else
                return ConvertList.TableToList<Batches>(ds.Tables[0]);
        }

        public int SaveBatches(List<StudentBatchMapping> b)
        {
            string Query = "INSERT INTO [dbo].[StudentBatchMapping] VALUES";
            foreach (var v in b)
                Query += "(" + v.StudentId + "" + "," + v.EnrollmentId + "" + "," + v.BatchId + "" + "," + v.CreatedBy + "" + ",'" + v.CreatedDate + "" + "'," + v.ModifyBy + "" + ",'" + v.ModifyDate + "'),";

            Query = Query.Substring(0, Query.LastIndexOf(","));
            var result = SqlHelper.ExecuteNonQuery(db.GetConnection(), CommandType.Text, Query);
            return 0;
        }

        public List<int> FindBatchesForStudentDescipline(long studentid, long enrollmentid, long disciplineid)
        {
            string Query = "select BatchId from [dbo].[StudentBatchMapping] where StudentId=(select StudentId from [dbo].[StudentEnrollment] where DisciplineId=" + disciplineid + " and EnrollmentId=" + enrollmentid + " and StudentId=" + studentid + ") and EnrollmentId=(select EnrollmentId from [dbo].[StudentEnrollment] where DisciplineId=" + disciplineid + " and EnrollmentId=" + enrollmentid + " and StudentId=" + studentid + ")";
            var ds = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (ds == null)
                return new List<int>();
            else
            {
                var x = new List<int>();
                foreach (DataRow v in ds.Tables[0].Rows)
                    x.Add(Convert.ToInt32(v[0]));
                return x;
            }
        }

        public int UpdateBatchesForStudent(List<StudentBatchMapping> b,long studentId,long enrollemntId)
        {
            string Query = string.Empty;
            Query = "delete from [StudentBatchMapping] where studentid=" + studentId + " and Enrollmentid=" + enrollemntId + "";
            var result = SqlHelper.ExecuteNonQuery(db.GetConnection(), CommandType.Text, Query);
            Query = string.Empty;
            Query = "INSERT INTO [dbo].[StudentBatchMapping] VALUES";
            foreach (var v in b)
                Query += "(" + v.StudentId + "" + "," + v.EnrollmentId + "" + "," + v.BatchId + "" + "," + v.CreatedBy + "" + ",'" + v.CreatedDate + "" + "'," + v.ModifyBy + "" + ",'" + v.ModifyDate + "'),";

            Query = Query.Substring(0, Query.LastIndexOf(","));
            var result1 = SqlHelper.ExecuteNonQuery(db.GetConnection(), CommandType.Text, Query);
            return 0;
        }
        //public List<Expenses> GetAllExpenses(int centerId, out int TotalPages, int PageNumber = 1, string search = "")
        //{
        //    int RowsPerPage = ConfigurationWrapper.PageSize; 
        //    SqlParameter[] spParameter = new SqlParameter[6];
        //    var pcenterId = new SqlParameter("@CentreId", centerId);
        //    var rowsPerpage = new SqlParameter("@RowsPerPage", RowsPerPage);
        //    var rowNo = new SqlParameter("@PageNumber", PageNumber);
        //    var total = new SqlParameter("@TotalPages", 0) { Direction = System.Data.ParameterDirection.Output };
        //    var psearch = new SqlParameter("@search", search);
        //    SqlCommand cmd = new SqlCommand("GetAllExpenses", db.GetConnection());
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    DataSet ds = new DataSet();
        //    cmd.Parameters.Add(pcenterId);
        //    cmd.Parameters.Add(rowsPerpage);
        //    cmd.Parameters.Add(rowNo);
        //    cmd.Parameters.Add(total);
        //    cmd.Parameters.Add(psearch);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(ds);
        //    TotalPages = Convert.ToInt32(total.Value);
        //    if (ds == null)
        //        return new List<Expenses>();
        //    else
        //        return ds.Tables[0].TableToList<Expenses>();
        //}


    }
}