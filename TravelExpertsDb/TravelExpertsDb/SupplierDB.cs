
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsDb
{
   public static class SupplierDB
    {
        public static bool AddNewSupplier(string newSupplier)
        {

            SqlConnection connection = DataAccess.getConnection();
            string insertStatement = "Insert into Suppliers Values (@SupName)";


            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@SupName", newSupplier);

            try
            {
                connection.Open();

                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.GetType() + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
         
        }
    }
}
