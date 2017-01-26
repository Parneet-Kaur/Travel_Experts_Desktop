using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsDb
{
    public static class PackagesDb
    {
       
        public static Packages getPackage(int packageID)
        {

            SqlConnection con = DataAccess.getConnection();
            string query = "SELECT * FROM  packages where " +
                            "packageID=@packageID";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.Add("@packageID", SqlDbType.Int).Value = packageID;
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            Packages package = new Packages();
            while (reader.Read())
            {

                package.PackageID = Convert.ToInt16(reader[0].ToString());
                package.PkgName = reader[1].ToString();
                bool flagOD = (reader["pkgStartDate"] != System.DBNull.Value);
                if (flagOD)
                {
                    package.PkgStartDate = (DateTime)(reader["pkgStartDate"]);
                }
                else
                {
                    package.PkgStartDate = DateTime.MinValue;
                }
                flagOD = (reader["pkgEndDate"] != System.DBNull.Value);
                if (flagOD)
                {
                    package.PkgEndDate = (DateTime)(reader["pkgEndDate"]);
                }
                else
                {
                    package.PkgEndDate = DateTime.MinValue;
                }
                flagOD = (reader["pkgDesc"] != System.DBNull.Value);
                if (flagOD)
                {
                    package.PkgDesc = (reader["pkgDesc"]).ToString();
                }
                else
                {
                    package.PkgDesc = "";
                }
                decimal money = Math.Round(Convert.ToDecimal(reader["pkgBasePrice"].ToString()));
                package.PkgBasePrice = money;
                flagOD = (reader["PkgAgencyCommission"] != System.DBNull.Value);
                if (flagOD)
                {
                    decimal commision = Math.Round(Convert.ToDecimal(reader["PkgAgencyCommission"].ToString()));
                    package.PkgAgencyCommission = commision;
                }
                else
                {
                    package.PkgAgencyCommission = 0;
                }


            }
            con.Close();
            return package;

        }/// end of method to get packages


        //to  get all packageID's  from DB
        public static DataTable getPackageIDs()
        {
            SqlConnection con = DataAccess.getConnection();
            string query = "select PackageId,PkgName from Packages";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            con.Close();
            return dt;


        }


        //to update packages in the database
        public static int updatePackage(Packages package)
        {

            SqlConnection con = DataAccess.getConnection();
            string query = "UPDATE packages SET " +
                 " pkgStartDate = @PkgStartDate, " +
                 " pkgEndDate = @PkgEndDate," +
                 " pkgDesc = @PkgDesc," +
                 " pkgBasePrice =  @PkgBasePrice," +
                 " pkgAgencyCommission =  @PkgAgencyCommission " +
                 "where " +
                 " packageID = @PackageID";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@pkgEndDate", package.PkgEndDate);
            com.Parameters.AddWithValue("@pkgStartDate", package.PkgStartDate);
            com.Parameters.AddWithValue("@pkgDesc", package.PkgDesc);
            com.Parameters.AddWithValue("@pkgBasePrice", package.PkgBasePrice);
            com.Parameters.AddWithValue("@pkgAgencyCommission", package.PkgAgencyCommission);
            com.Parameters.AddWithValue("@packageID", package.PackageID);

            con.Open();
            int success = com.ExecuteNonQuery();

            con.Close();
            return success;
        }

        public static List<Product> GetProducts()
        {


            SqlConnection connection = DataAccess.getConnection();
            string selectStatement = "SELECT ProductId, ProdName " +
                                     "FROM Products ORDER BY ProdName Asc";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            connection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var products = new List<Product>();
            while (reader.Read())
            {
                //for each record fill out a product
                var product = new Product();
                product.ProductId = Convert.ToInt32(reader["ProductId"]);
                product.ProdName = reader["ProdName"].ToString();
                products.Add(product);
            }

            connection.Close();
            return products;
        }//end of function

        //populate listview with existing items in package
        public static List<PackageProductDetails> GetPackageProductDetails(int packageID)
        {
            SqlConnection connection = DataAccess.getConnection();
            string selectStatement = "select * from Products_Suppliers ps inner join Products p on " +
" ps.ProductId = p.ProductId inner join Suppliers s on " +
" ps.SupplierId = s.SupplierId where ps.ProductSupplierId in ( " +
   "select productSupplierId from Packages_Products_Suppliers where @PackageId = PackageID)";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PackageId", packageID);
            connection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var products = new List<PackageProductDetails>();
            while (reader.Read())
            {
                //for each record fill out a product details for  that package
                PackageProductDetails product = new PackageProductDetails();
                product.supplierName = reader["SupName"].ToString();
                product.prodName = reader["ProdName"].ToString();
                product.ProductId = Convert.ToInt16(reader["ProductId"]);
                products.Add(product);
            }

            connection.Close();
            return products;
        }

        public static List<Supplier> GetAllSupplier(int ProductID)
        {

            SqlConnection con = DataAccess.getConnection();
            string query = "select * from Products_Suppliers ps inner join Suppliers s " +
                                "on ps.supplierid = s.supplierid  where @ProductId = ProductID";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@ProductId", ProductID);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            List<Supplier> suplist = new List<Supplier>();

            while (reader.Read())
            {
                Supplier sup = new Supplier();
                sup.SupplierId = Convert.ToInt16(reader["SupplierId"]);
                sup.SupName = reader["SupName"].ToString();
                sup.ProductSupplierId = Convert.ToInt16(reader["ProductSupplierId"]);
                suplist.Add(sup);
            }
            con.Close();
            return suplist;
        }


        public static int AddPackageDetails( int product_supplierID)
        {
             
                     SqlConnection connection = DataAccess.getConnection();
                    string selectStatement = "SELECT IDENT_CURRENT('Packages') FROM Packages";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                    int newPackageId = 0;
                    try
                    {
                        connection.Open();
                        newPackageId = Convert.ToInt32(selectCommand.ExecuteScalar()); //Grabbing the new packageID.
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.GetType() + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                    string insertStatement = @"INSERT INTO Packages_Products_Suppliers VALUES (@PackageId, @ProductSupplierId)";
                    SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                    insertCommand.Parameters.AddWithValue("@PackageId", newPackageId);
                    insertCommand.Parameters.AddWithValue("@ProductSupplierId", product_supplierID);
                    try
                    {
                        connection.Open();
                        int success = insertCommand.ExecuteNonQuery();
                        return success;
                    }
                    catch (SqlException ex)
                    {
                       
                        MessageBox.Show(ex.GetType() + ex.Message);
                    return -1;
                     }

                    finally
                    {
                        connection.Close();

                    }
            
        }//end of function

        public static int AddPackage(Packages package) {
    SqlConnection connection = DataAccess.getConnection();

    string InsertStatement = @"INSERT into Packages VALUES (@PkgName, @PkgStartDate, @PkgEndDate,
                                       @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";


    SqlCommand insertPackage = new SqlCommand(InsertStatement, connection);

    insertPackage.Parameters.AddWithValue("@PkgName", package.PkgName);
    insertPackage.Parameters.AddWithValue("@PkgStartDate", (object)package.PkgStartDate);
    insertPackage.Parameters.AddWithValue("@PkgEndDate", (object)package.PkgEndDate);
    insertPackage.Parameters.AddWithValue("PkgDesc", package.PkgDesc);
    insertPackage.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
    insertPackage.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);

    
        try
        {
            connection.Open();
            int success = insertPackage.ExecuteNonQuery();
            return success;
        }
        catch (SqlException ex)
        {

            MessageBox.Show("Couldn't update the package, please contact support.");
            return -1;
        }
        finally
        {
            connection.Close();
        }
    }//end of function 

        public static int UpdateProductSupplier(int packageId, int supplierId, int productId)
        {

            int productSupplierId = -1; //to store the productSupplierID returned by db

            //get productSupplierID from db to make tht the product is being supplied, if at all
            SqlConnection connection = DataAccess.getConnection();
            string insertStatement = "select productSupplierId from Products_Suppliers where @ProductId "
                        + "=productId and @SupplierId=supplierId";
            SqlCommand Command = new SqlCommand(insertStatement, connection);
            Command.Parameters.AddWithValue("@ProductId", productId);
            Command.Parameters.AddWithValue("@SupplierId", supplierId);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            try
            {
                //string test = reader["productSupplierId"].ToString();

                if (reader.Read())
                {
                    productSupplierId = Convert.ToInt16(reader["productSupplierId"]);
                }
                else
                {
                    MessageBox.Show("This product is not being supplied yet, please update the supplier in the database first.");
                }
                //if (reader["productSupplierId"] !=System.DBNull.Value) {
                //    productSupplierId = Convert.ToInt16(reader["productSupplierId"]);
                //}
                //else {
                //    MessageBox.Show("This product is not being supplied yet, please update the supplier in the database first.");
                //}

                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.GetType() + ex.Message);

            }



            // if a particular product is being supplied then add it to the package
            string updatePkgDetails = @"INSERT INTO Packages_Products_Suppliers VALUES (@PackageId, @ProductSupplierId)";
            SqlCommand ins = new SqlCommand(updatePkgDetails, connection);
            ins.Parameters.AddWithValue("@PackageId", packageId);
            ins.Parameters.AddWithValue("@ProductSupplierId", productSupplierId);
            try
            {
                connection.Open();
                int success = ins.ExecuteNonQuery();
                return success;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.GetType() + ex.Message);
                return -1;//-1 means updation failed
            }
            finally
            {
                connection.Close();

            }

        }//end of function


        public static int addProductSupplierToPackage(int productSupplierId, int packageId)
        {

            SqlConnection connection = DataAccess.getConnection();
            string updatePkgDetails = @"INSERT INTO Packages_Products_Suppliers VALUES (@PackageId, @ProductSupplierId)";
            SqlCommand ins = new SqlCommand(updatePkgDetails, connection);
            ins.Parameters.AddWithValue("@PackageId", packageId);
            ins.Parameters.AddWithValue("@ProductSupplierId", productSupplierId);
            try
            {
                connection.Open();
                int success = ins.ExecuteNonQuery();
                return success;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.GetType() + ex.Message);
                return -1;//-1 means updation failed
            }
            finally
            {
                connection.Close();

            }

        }

        public static DataTable GetAllPackages() {

            SqlConnection connection = DataAccess.getConnection();
            string com = "SELECT * FROM PACKAGES";
            SqlCommand command = new SqlCommand(com,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();
            return dt;
        }

    }// end of class

    
}
