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

namespace TravelExpertsDb.Forms
{
    public partial class FrmNewProduct : MaterialForm
    {
        public FrmNewProduct()
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
            if(Validator.IsPresent(txtNewProduct))
            {
                string newProduct = txtNewProduct.Text;

                List<Product> allProducts = ProductDB.GetProducts();

                if(ConfirmDuplicateProduct(newProduct, allProducts))
                {
                    ProductDB.AddNewProduct(newProduct); //enter into the database
             
                    // for each item in the current suppliers in this new product, we are going to add the supplier into the database
                    //however if there is nothing in the listview item... it will return nothing
                    //This is how we will allow products to be added to suppliers...
                    foreach (ListViewItem supplier in lvCurrentSuppliers.Items)
                    {
                        
                        int supplierid = Convert.ToInt32(supplier.SubItems[1].Text);

                        ProductDB.InsertProductToSupplier(supplierid);
                    }
                    MessageBox.Show(newProduct + " has been successfully added to the database.", "Success");

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(newProduct + " already exists in the database!", "Error");

                }


                }//Validator is present

            }//button ok click



        //Confirming if the product is in the database or not
        private static bool ConfirmDuplicateProduct(string newProduct, List<Product> allProducts)
        {

            foreach (Product product in allProducts)// You can change to regular expression to grab all the instances of the product
            {
                if (product.ProdName == newProduct)
                {
                    
                    return false;
                }

            }
            return true;
        }

        private void FrmNewProduct_Load(object sender, EventArgs e)
        {

            lbAllSuppliers.DataSource = SupplierDB.GetAllSuppliers();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductSupplier supplier = (ProductSupplier)lbAllSuppliers.SelectedItem;

            int newSupplierID = supplier.SupplierId;
            string newSupplierName = supplier.SupName;

            string[] row = {  newSupplierName, newSupplierID.ToString() };

            var ListViewItem = new ListViewItem(row);

            lvCurrentSuppliers.Items.Add(ListViewItem);


            //Method for having an interactive back and forth suppliers
            List<ProductSupplier> remainingSuppliers = SupplierDB.GetAllSuppliers();

            List<int> SupplierIds = new List<int>();

            foreach (ListViewItem item in lvCurrentSuppliers.Items)
            {
                int SupplierId = Convert.ToInt32(item.SubItems[1].Text);
               SupplierIds.Add(SupplierId); // adding this to the list of suppliers for the product

            }

            var suppliersNotIn = from supplierid in remainingSuppliers
                                 where !(SupplierIds.Any(newsupplier => newsupplier == supplierid.SupplierId))
                                 select supplierid;

            List<ProductSupplier> suppliersRemaining = new List<ProductSupplier>();
            foreach (var supplierid in suppliersNotIn)
            {
                suppliersRemaining.Add(supplierid);
            }


            lbAllSuppliers.DataSource = suppliersRemaining;






        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvCurrentSuppliers.SelectedItems)
            {

                lvCurrentSuppliers.Items.Remove(item);
            }


            //Method for having an interactive back and forth suppliers
            List<ProductSupplier> remainingSuppliers = SupplierDB.GetAllSuppliers();

            List<int> SupplierIds = new List<int>();

            foreach (ListViewItem item in lvCurrentSuppliers.Items)
            {
                int SupplierId = Convert.ToInt32(item.SubItems[1].Text);
                SupplierIds.Add(SupplierId); // adding this to the list of suppliers for the product

            }

            var suppliersNotIn = from supplierid in remainingSuppliers
                                 where !(SupplierIds.Any(newsupplier => newsupplier == supplierid.SupplierId))
                                 select supplierid;

            List<ProductSupplier> suppliersRemaining = new List<ProductSupplier>();
            foreach (var supplierid in suppliersNotIn)
            {
                suppliersRemaining.Add(supplierid);
            }


            lbAllSuppliers.DataSource = suppliersRemaining;
        }
    }//FormProduct
    }//NameSpace



