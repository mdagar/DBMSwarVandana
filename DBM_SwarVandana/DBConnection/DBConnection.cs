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
        SqlConnection _connection;
        public SqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Repository"].ConnectionString;
            _connection = new SqlConnection(connStr);
            return _connection;
        }
    }
}