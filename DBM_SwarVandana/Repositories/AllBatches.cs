using DBConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repositories
{
    public class AllBatches
    {

        DBConnections db = new DBConnections();        

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