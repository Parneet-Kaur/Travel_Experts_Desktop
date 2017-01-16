
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
        //Callias Nguyen
        public static bool AddNewSupplier(string newSupplier)//method to add new supplier into the database
                                                             //Returns false if it does not work
        {
            int currentHighestSupplierId = 0; //set the current supplierid to 0

            SqlConnection connection = DataAccess.getConnection();

            string selectMaxStatement = "Select Max(SupplierId) from Suppliers";

            SqlCommand maxsupplieridCommand = new SqlCommand(selectMaxStatement, connection);

            try
            {
                connection.Open();
                currentHighestSupplierId = Convert.ToInt32(maxsupplieridCommand.ExecuteScalar()); //Grabbing the highest supplier id from the table
                //because supplierid is not incremented
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.GetType() + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            int newSupplierId = currentHighestSupplierId + 1; //creating a newSupplierId


            //Now we are inserting the supplier into the database

            string insertStatement = "Insert into Suppliers Values (@SupId, @SupName)";


            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@SupName", newSupplier);
            insertCommand.Parameters.AddWithValue("@SupId", newSupplierId);

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

        /// SEPARATING METHODS
        /// 
        ///
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        ///
        ///
        ///
        /// SEPARATING METHODS



        // Grab all suppliers in the Database
        public static List<ProductSupplier> GetAllSuppliers()
        {
            SqlConnection connection = DataAccess.getConnection();

            string selectStatement = @"Select Supplierid, SupName from suppliers
                                        ORDER BY SupName Asc ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            List<ProductSupplier> suppliers = new List<ProductSupplier>();
            try
            {

                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    ProductSupplier productsupplier = new ProductSupplier();
                    productsupplier.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    productsupplier.SupName = Convert.ToString(reader["supName"]);
                    suppliers.Add(productsupplier);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.GetType() + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return suppliers;
        }

        /// SEPARATING METHODS
        /// 
        ///
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        ///
        ///
        ///
        /// SEPARATING METHODS


        public static bool UpdateSupplier(ProductSupplier oldSupplier, string newSupplierName)
        {
            SqlConnection connection = DataAccess.getConnection();

            string updateStatement = @"UPDATE Suppliers SET SupName = @newSupName
                                         WHERE SupplierId = @supplierId AND SupName = @oldSupName";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@newSupName", newSupplierName);
            updateCommand.Parameters.AddWithValue("@supplierId", oldSupplier.SupplierId);
            updateCommand.Parameters.AddWithValue("@oldSupName", oldSupplier.SupName);

            try
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();
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

        /// SEPARATING METHODS
        /// 
        ///
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        ///
        ///
        ///
        /// SEPARATING METHODS

        public static List<string> AttachedPackagesFromSuppliers(ProductSupplier currentSupplier)
        {
            SqlConnection connection = DataAccess.getConnection();

            string selectStatement = @"SELECT PkgName From Packages p
                                        INNER JOIN Packages_Products_Suppliers pps
                                        ON pps.PackageId = p.PackageId
                                        WHERE ProductSupplierId = @ProductSupplierId ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductSupplierId", currentSupplier.ProductSupplierId);
        

            List<string> attachedPackages = new List<string>();


            try
            {
                connection.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    string attachedPackage = reader["PkgName"].ToString();
                    attachedPackages.Add(attachedPackage);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.GetType() + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return attachedPackages;
        }
    }
}

