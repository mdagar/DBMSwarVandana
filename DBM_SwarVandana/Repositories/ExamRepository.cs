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
    public class ExamRepository
    {
        DBConnections db = new DBConnections();
        public int InsertExamDetails(ExamDetails ed)
        {
            object[] objParam = { ed.ActionID,ed.ExamID,ed.StudentID,ed.ExamName,ed.ExamDate,ed.FacultyID,ed.ExamFees,ed.Comments,ed.ResultOfExam,ed.CentreID
                                ,ed.CreatedBy,ed.CreatedOn,ed.ModifiedBy,ed.ModifiedOn,ed.IsActive,ed.IsDeleted};
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.InsertExamDetails, objParam);
            return Convert.ToInt32(d);
        }

        
        public List<ExamDetails> GetExamDetailsByCentreID(int CentreID, out int TotalPages, int PageNumber = 1, string search = "")
        {
            int RowsPerPage = ConfigurationWrapper.PageSize;
            SqlParameter[] spParameter = new SqlParameter[6];
            var pcenterId = new SqlParameter("@CentreId", CentreID);
            var rowsPerpage = new SqlParameter("@RowsPerPage", RowsPerPage);
            var rowNo = new SqlParameter("@PageNumber", PageNumber);
            var total = new SqlParameter("@TotalPages", 0) { Direction = System.Data.ParameterDirection.Output };
            var psearch = new SqlParameter("@search", search);
            SqlCommand cmd = new SqlCommand("GetExamDetailsByCentreID", db.GetConnection());
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
                return new List<ExamDetails>();
            else
                return ds.Tables[0].TableToList<ExamDetails>();
            //object[] objParam = { CentreID, search };
            //var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetExamDetailsByCentreID, objParam);
            //if (d == null)
            //    return new List<ExamDetails>();
            //else
            //    return d.Tables[0].TableToList<ExamDetails>();
        }

        public ExamDetails GetExamDetailsByExamID(Int64 ExamID)
        {
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetExamDetailsByExamID, ExamID);
            if (d == null)
                return new ExamDetails();
            else
                return d.Tables[0].TableToList<ExamDetails>().FirstOrDefault();
        }
    }
}