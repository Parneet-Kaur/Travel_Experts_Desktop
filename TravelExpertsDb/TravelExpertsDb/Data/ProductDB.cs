using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace TravelExpertsDb
{//Callias Nguyen
    // January 25, 2017
// ProductDB for refreshing/adding/editing anything to do with products
    public static class ProductDB
    {

        //adding a new product to the database
        public static bool AddNewProduct(string productName)
        {
            SqlConnection connection = DataAccess.getConnection();

            string insertStatement = "Insert into Products Values (@ProdName) ";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@ProdName", productName);

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



        //Get all products from the database
        public static List<Product> GetProducts(){


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
        }


        //Grab the Product's current supplier 
        public static List<ProductSupplier> GetProductSuppliers(Product product)
        {
            SqlConnection connection = DataAccess.getConnection();

            string selectStatement = "SELECT ps.SupplierId, SupName, ProductSupplierId FROM Products_Suppliers ps " +
                                     "INNER JOIN Suppliers s " +
                                     "ON s.SupplierId = ps.SupplierId " +
                                     "WHERE ProductId = @ProductId " +
                                     "ORDER BY SupName ASC";

            SqlCommand command = new SqlCommand(selectStatement, connection);

            command.Parameters.AddWithValue("@ProductId", product.ProductId);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            var prodSuppliers = new List<ProductSupplier>();
            while (reader.Read())
            {
                var prodSupplier = new ProductSupplier();

                prodSupplier.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);
                prodSupplier.SupName = reader["SupName"].ToString();
                prodSupplier.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                prodSuppliers.Add(prodSupplier);

            }

            connection.Close();

            return prodSuppliers;
        }


        //getting the suppliers that are not in the current product
        public static List<ProductSupplier> GetSuppliersNotInProduct(Product product)
        {
            SqlConnection connection = DataAccess.getConnection();

            List<ProductSupplier> remainingProductSuppliers = product.GetSuppliers();

            /////////////////FIX THIS ISSUES CAUSING PROBLEMS/////////////////////////////////////////////////////////////////////////

            //var stringList = new List<string>();
            //foreach (ProductSupplier remainProductSupplier in remainingProductSuppliers)
            //{
            //    stringList.Add(remainProductSupplier.SupplierIdToString());
            //}

            //need the $ sign to join a betweens....


            //string selectStatement = $@"SELECT DISTINCT s.SupplierId, SupName
            //                         FROM Suppliers s 
            //                         INNER JOIN Products_Suppliers ps ON ps.SupplierId = s.SupplierId
            //                         WHERE s.SupplierId NOT IN ({string.Join(", ", stringList)})
            //                         ORDER BY SupName ASC";

            //NEED TO FIX THIS SELECT STATEMENT
            //
            //

            //this is how we are going to grab suppliers that are moved out of the product
            string selectStatement = @"SELECT distinct s.SupplierId, SupName FROM Suppliers s
                                              WHERE s.supplierId NOT IN(select SupplierId from Products_Suppliers
                                                 WHERE ProductId = @ProductId)
                                              ORDER by SupName asc";
            //
            //
            //
            //
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductId", product.ProductId);


            List<ProductSupplier> productSuppliers = new List<ProductSupplier>();

            try
            {
                connection.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();


                while (reader.Read())
                {
                    ProductSupplier productSupplier = new ProductSupplier();
                    //productSupplier.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);
                    productSupplier.SupName = reader["SupName"].ToString();
                    productSupplier.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    productSuppliers.Add(productSupplier);
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

            return productSuppliers;
        }

        //removing a product supplier... given that the package and bookings are removed from that respective productsupplier
        public static void RemoveProductsSupplier(Product product, ProductSupplier supplier)
        {

            SqlConnection connection = DataAccess.getConnection();

            string deleteStatement = @"Delete from Products_suppliers WHERE ProductId = @productid
                                    AND supplierId = @supplierId";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);

            deleteCommand.Parameters.AddWithValue("@productid", product.ProductId);
            deleteCommand.Parameters.AddWithValue("@supplierId", supplier.SupplierId);

            try
            {
                connection.Open();
                deleteCommand.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot delete supplier " + supplier.SupName + " from product " + product.ProdName + " as it is currently supplied in a package(s).", "Deletion Error");
            }
            finally
            {
                connection.Close();
            }
        }


        //Add the supplier to the product
        public static void AddSuppliertoProduct(Product product, ProductSupplier supplier)
        {
            SqlConnection connection = DataAccess.getConnection();


            string insertStatement = @"Insert into Products_suppliers Values (@productid, @supplierid)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@productid", product.ProductId);
            insertCommand.Parameters.AddWithValue("@supplierid", supplier.SupplierId);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Supplier or Product has been updated/deleted from the database. Please try again.", "Database Updated");
            }
            finally
            {
                connection.Close();
            }

        }

        //updating the product name in the database
        public static bool UpdateProductName(Product oldProduct, string newProductName)
        {
            SqlConnection connection = DataAccess.getConnection();

            string updateStatement = @"UPDATE Products SET ProdName = @newProdName
                                         WHERE ProductId = @ProductId AND ProdName = @oldProdName";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@newProdName", newProductName);
            updateCommand.Parameters.AddWithValue("@ProductId", oldProduct.ProductId);
            updateCommand.Parameters.AddWithValue("@oldProdName", oldProduct.ProdName);

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


        ////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////


            //Inserting a supplier into a new product......
            //Method to instantly create a product and supplier
        public static bool InsertProductToSupplier(int supplierId)
        {
            SqlConnection connection = DataAccess.getConnection();

            string selectStatement = "SELECT IDENT_CURRENT('Products') FROM Products";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            int newProductId = 0;

            try
            {
                connection.Open();
                newProductId = Convert.ToInt32(selectCommand.ExecuteScalar());


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


            string insertStatement = "INSERT INTO Products_Suppliers Values (@ProductId, @SupplierId)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@ProductId",newProductId);
            insertCommand.Parameters.AddWithValue("@SupplierId", supplierId);
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

    //updating a NEW supplier with an added products
        public static bool UpdateNewProductsWithaSupplier(int productId)
        {
            int currentHighestSupplierId = 0; //set the current supplierid to 0
            //since the supplierid is not incremented this is how we are going to grab the supplierID that has been inserted

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

            int newSupplierId = currentHighestSupplierId; //after you insert the supplier into the database,
            //the highest number is going to be the newSupplierid.....


            string insertStatement = "INSERT INTO Products_Suppliers Values (@ProductId, @SupplierId)"; //Now we have all the information, this is how we are going to insert information
            //into the database

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@ProductId", productId);
            insertCommand.Parameters.AddWithValue("@SupplierId", newSupplierId);
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



    }//public ProductDB
}//NameSpace
    
