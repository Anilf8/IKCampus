using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusDeneme._02
{
    public class SqlOperations
    {
        // SQL connection string for connecting to the database
        public static SqlConnection connection = new SqlConnection(
            "Data Source=DESKTOP-Q4B5HH1\\SQLEXPRESS;Initial Catalog=OKULDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

        // Method to check and open the SQL connection if it is closed
        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State == ConnectionState.Closed)
            {
                tempConnection.Open(); // Open the connection if it is closed
            }
        }
    }
}
