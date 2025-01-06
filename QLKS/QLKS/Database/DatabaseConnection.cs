using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLKS.Database
{
    public static class DatabaseConnection
    {
        public static readonly string connectionString = "Data Source=DESKTOP-HDPCSE2\\SQLEXPRESS;Initial Catalog=QLKS1;Integrated Security=True;TrustServerCertificate=True";
        private static SqlConnection _conn;

        public static SqlConnection Connection
        {
            get
            {
                if (_conn == null)
                {
                    _conn = new SqlConnection(connectionString);
                }
                return _conn;
            }
        }
    }
}
