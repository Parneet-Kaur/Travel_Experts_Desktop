using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsDb
{
     class DataAccessLogin
    {
       
                      
        public bool validateCredentials(string user,string password)
        {

            //string connectionString = "Data Source=ICTVM-IVMOQ3HR1\\SQLEXPRESS;" +
            //                          "Database=TravelExperts;" +
            //                          "Integrated Security=True";


            //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TravelExperts.mdf;Integrated Security = True; Connect Timeout = 30";

            //SqlConnection connection = new SqlConnection(connectionString);


            SqlConnection connection = DataAccess.getConnection();


            try
            {
                connection.Open();


                SqlCommand com = new SqlCommand("Select AgtBusPhone from agents where agentid=" + user, connection);
                SqlDataReader r = com.ExecuteReader();
                //bool result = r.Read();//bug fix; doesn't work without this

                if (r.Read())// if reader returns false then the password is incorrect
                {
                    string pass = r["AgtBusPhone"].ToString();//for testing
                    return true;
                }
                else
                {
                    return false;
                }
                //if (r[0].ToString() != password)
                //{

                //    return false;
                //}
                //     return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
             
            
        }
  

    }
}
