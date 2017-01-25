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
       //Parneet Kaur
                      

            //validating the login page to confirm if the user exists
        public bool validateCredentials(string user,string password)
        {



            SqlConnection connection = DataAccess.getConnection();

            //just a statement to confirm if the agent has a username and password... being the agtBustPhone
            string selectStatement = "Select * from agents where agentid = @User AND  AgtBusPhone = @Password ";

            
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@User", user);//security protection
            selectCommand.Parameters.AddWithValue("@Password", password); //security protection
            try
            {
                connection.Open();

                SqlDataReader r = selectCommand.ExecuteReader(); //executing the reader to work....
           

                if (r.Read())// if reader returns false then the password is incorrect
                {
                    string pass = r["AgtBusPhone"].ToString();//for testing
                    return true;
                }
                else
                {
                    return false;
                }
            
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
