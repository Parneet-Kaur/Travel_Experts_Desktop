using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDb
{
     class DataAccessLogin
    {
        string connectionString = "Data Source=ICTVM-IVMOQ3HR1\\SQLEXPRESS;" +
                       "Database=TravelExperts;" +
                       "Integrated Security=True";

        
       
        public bool validateCredentials(string user,string password) {

            string connectionString = "Data Source=ICTVM-IVMOQ3HR1\\SQLEXPRESS;" +
                                      "Database=TravelExperts;" +
                                      "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            SqlCommand com = new SqlCommand("Select AgtBusPhone from agents where agentid="+user, connection);
            SqlDataReader r = com.ExecuteReader();
            bool result = r.Read();//bug fix; doesn't work without this
            string pass = r[0].ToString();//for testing
            
            if (r[0].ToString() != password)
            {
                connection.Close();
                return false;
            }
            else {
                connection.Close();
                return true;
            }

            
        }
  

    }
}
