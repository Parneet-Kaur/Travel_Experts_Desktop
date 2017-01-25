using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Callias Nguyen, Abel Surace
//
// Date: January 24, 2017
// New Suppliers
//


namespace TravelExpertsDb.Forms
{
    public partial class FrmNewSupplier : MaterialForm
    {
        public FrmNewSupplier()
        {
            InitializeComponent();
        }


        //Cannot actually focus on the text.... for material skin so i didn't bother implementing a focus here

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        
        private void btnOk_Click(object sender, EventArgs e)
        {

            
            if (Validator.IsPresent(txtNewSupplierName))//confirming that the user entered data
            {
                string newSupplierName = (txtNewSupplierName.Text).ToUpper(); //Change the new name to all uppercase like the Database

                if (ConfirmNewSupplier(newSupplierName))//confirming if the supplier is in the database or not....
                {

                    if (SupplierDB.AddNewSupplier(newSupplierName))// inserting the supplier into the database
                    {
                        //Adding the following products for the selected supplier..
                        foreach (ListViewItem item in lvChosenProducts.Items)
                        {

                            int productid = Convert.ToInt32(item.SubItems[1].Text); //grabbing the productid for each  of the products chosen for
                            //this new supplier

                            ProductDB.UpdateNewProductsWithaSupplier(productid); //method to update products with the new supplier
                        }


                        MessageBox.Show(newSupplierName + " has been successfully been added to the database", "Success");
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show(newSupplierName + " is already in the database", "Failure");
                }
            }
        }//btn Ok Click




        private void FrmNewSupplier_Load(object sender, EventArgs e)
        {

            lbAllProducts.DataSource = ProductDB.GetProducts(); //inserting the datasource with all products
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvChosenProducts.SelectedItems)
            {
                lvChosenProducts.Items.Remove(item);// each item that is chosen on the listview, we are going to remove it
            }

            //refresh the datasource for the products
            lbAllProducts.DataSource = UpdateProductList();

            //making sure there is an item in the product section
            if (UpdateProductList().Count == 0)
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = (Product)lbAllProducts.SelectedItem;
            int productId = product.ProductId;
            string productName = product.ProdName;

            string[] row = { productName, productId.ToString() };

            var ListviewItem = new ListViewItem(row);

            //add the product into the chosen product listview
            lvChosenProducts.Items.Add(ListviewItem);



            //refresh the datasource for the products
            lbAllProducts.DataSource = UpdateProductList();

            if (UpdateProductList().Count == 0)
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        // method to confirm if the supplier has already existed
        private static bool ConfirmNewSupplier(string newSupplier)
        {
            List<ProductSupplier> allSuppliers = SupplierDB.GetAllSuppliers();

            foreach (ProductSupplier supplier in allSuppliers)
            {
                if (supplier.SupName == newSupplier) //comparing a string to a class of supplier and returning false if suppliers match.
                {
                    return false;
                }

            }
            return true;

        }





       

     
          

   


        private List<Product> UpdateProductList()
        { //Grab all the products in the database 
            List<Product> originalProduct = ProductDB.GetProducts();

            //grab all the chosenProducts from the listview to compare
            //with the original product list
            List<int> chosenProducts = new List<int>();


            //populating the chosenProducts list with the productid in the listview
            foreach (ListViewItem item in lvChosenProducts.Items)
            {
                int productId = Convert.ToInt32(item.SubItems[1].Text);
                chosenProducts.Add(productId);

            }

            var ProductsNotIn = from productId in originalProduct
                                where !(chosenProducts.Any(newProductId => newProductId == productId.ProductId))
                                select productId;



            List<Product> productsRemaining = new List<Product>();
            foreach (var productId in ProductsNotIn)
            {
                productsRemaining.Add(productId);
            }

            return productsRemaining;

        }//UpdateProductList<>




    }//FrmSupplier
}
