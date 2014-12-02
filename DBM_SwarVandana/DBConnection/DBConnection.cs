using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace DBConnection
{
    public class DBConnections
    {
        public SqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Repository"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }
    }
}