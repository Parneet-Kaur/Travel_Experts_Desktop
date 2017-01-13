using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace TravelExpertsDb
{
    public static class ProductDB
    {
        public static List<Product> GetProducts()
        {
            

            SqlConnection connection = DataAccess.getConnection();

            string selectStatement = "SELECT ProductId, ProdName " +
                                     "FROM Products";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            connection.Open();

            SqlDataReader reader = selectCommand.ExecuteReader();

            var products = new List<Product>();
            while ( reader.Read() )
            {
                //for each record fill out a product
                var product = new Product();
                product.ProductId =  Convert.ToInt32(reader["ProductId"]);
                product.ProdName = reader["ProdName"].ToString();
                products.Add(product);
            }

            connection.Close();
            return products;
        }

        public static List<ProductSupplier> GetProductSuppliers( Product product )
        {
            SqlConnection connection = DataAccess.getConnection();

            string selectStatement = "SELECT ps.SupplierId, SupName, ProductSupplierId FROM Products_Suppliers ps " +
                                     "INNER JOIN Suppliers s ON s.SupplierId = ps.SupplierId " +
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

        public static List<ProductSupplier> GetSuppliersNotInProduct(Product product)
        {
            SqlConnection connection = DataAccess.getConnection();
            
            List<ProductSupplier> remainingProductSuppliers = product.GetSuppliers();

            var stringList = new List<string>();
            foreach (ProductSupplier remainProductSupplier in remainingProductSuppliers)
            {
                stringList.Add(remainProductSupplier.SupplierIdToString());
            }

            //need the $ sign to join a betweens....
            string selectStatement = $@"SELECT DISTINCT s.SupplierId, SupName, ProductSupplierId 
                                     FROM Suppliers s 
                                     INNER JOIN Products_Suppliers ps ON ps.SupplierId = s.SupplierId
                                     WHERE s.SupplierId NOT IN ({string.Join(", ", stringList)})
                                     ORDER BY SupName ASC";

            SqlCommand selectCommand = new SqlCommand(selectStatement,connection);
            



            connection.Open();

            SqlDataReader reader = selectCommand.ExecuteReader();

            List<ProductSupplier> productSuppliers = new List<ProductSupplier>();
            while (reader.Read())
            {
                var productSupplier = new ProductSupplier();
                productSupplier.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);
                productSupplier.SupName = reader["SupName"].ToString();
                productSupplier.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                productSuppliers.Add(productSupplier);
            }

            connection.Close();
            return productSuppliers;
        }

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
                MessageBox.Show("Cannot Delete Supplier from Product as it is currently in a package.", "Error");
            }
            finally
            {
                connection.Close();
            }
        }

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

    }
}
