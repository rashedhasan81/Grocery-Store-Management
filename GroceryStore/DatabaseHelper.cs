using System;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace GroceryStore
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString;

        static DatabaseHelper()
        {
            var conn = ConfigurationManager.ConnectionStrings["connString"];

            if (conn == null)
                throw new Exception("Connection string 'connString' not found in app.config");

            ConnectionString = conn.ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}