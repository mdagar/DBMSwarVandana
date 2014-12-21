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

        public List<ExamDetails> GetExamDetailsByCentreID(int CentreID, string search)
        {
            object[] objParam = { CentreID, search };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetExamDetailsByCentreID, objParam);
            if (d == null)
                return new List<ExamDetails>();
            else
                return d.Tables[0].TableToList<ExamDetails>();
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