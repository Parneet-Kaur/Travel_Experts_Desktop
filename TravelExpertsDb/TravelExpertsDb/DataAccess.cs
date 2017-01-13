using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDb
{
    public static class DataAccess
    {
        public static SqlConnection getConnection() {

            string connectionString = "Data Source=ICTVM-IVMOQ3HR1\\SQLEXPRESS;" +
                       "Database=TravelExperts;" +
                       "Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            return con;

        }
    }
}
