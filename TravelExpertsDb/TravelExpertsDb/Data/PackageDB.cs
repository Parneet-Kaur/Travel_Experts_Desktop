using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsDb.Entity;

namespace TravelExpertsDb.Data
{
    public static class PackageDB
    {


        public static bool AddNewPackage(Package package)
        {
            SqlConnection connection = DataAccess.getConnection();

            string insertStatement = @"INSERT into Packages VALUES (@PkgName, @PkgStartDate, @PkgEndDate,
                                       @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";


            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@PkgName", package.PkgName);
            insertCommand.Parameters.AddWithValue("@PkgStartDate", (object) package.PkgStartDate);
            insertCommand.Parameters.AddWithValue("@PkgEndDate", (object) package.PkgEndDate);
            insertCommand.Parameters.AddWithValue("PkgDesc", package.PkgDesc);
            insertCommand.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
            insertCommand.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.GetType() + ex.Message);
                return false; 
            }
            finally
            {
                connection.Close();
            }
            
        }//New Package


    /////////////////////////////////////////////////////////////////////////////////////////NEW METHOD///////////////



        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
       public static bool AddNewProductSupplierToPackage(int product_supplierID)
        {
            //where are u using the parameter from the function call
            SqlConnection connection = DataAccess.getConnection();
            string selectStatement = "SELECT IDENT_CURRENT('Packages') FROM Packages";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            int newPackageId = 0;
            try{
                connection.Open();
                newPackageId = Convert.ToInt32(selectCommand.ExecuteScalar()); //Grabbing the new packageID.
            }
            catch (SqlException ex){
                MessageBox.Show(ex.GetType() + ex.Message);
            }
            finally{
                connection.Close();
            }
            string insertStatement = @"INSERT INTO Packages_Products_Suppliers VALUES (@PackageId, @ProductSupplierId)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@PackageId", newPackageId);
            insertCommand.Parameters.AddWithValue("@ProductSupplierId", product_supplierID);
            try{
                connection.Open();
                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)            {
                MessageBox.Show(ex.GetType() + ex.Message);
                return false;
            }
            finally{
                connection.Close();
                
            }


        }


    }//end of class
}
