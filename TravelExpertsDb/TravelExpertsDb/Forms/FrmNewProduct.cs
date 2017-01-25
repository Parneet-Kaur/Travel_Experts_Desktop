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
{//Callias Nguyen & Abel Suraces

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


        //btnok is when u finalize the new Product you created
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(Validator.IsPresent(txtNewProduct)) //if the txt has a value then continue on 
            {
                string newProduct = txtNewProduct.Text;

                // we are confirming if this product is in the database first before entering it in the DB
                List<Product> allProducts = ProductDB.GetProducts();
                if(ConfirmDuplicateProduct(newProduct, allProducts))
                {
                    ProductDB.AddNewProduct(newProduct); //enter into the database
             
                    // for each item in the current suppliers in this new product, we are going to add the supplier into the database
                    //however if there is nothing in the listview item... it will return nothing
                    //This is how we will allow products to be added to suppliers...
                    foreach (ListViewItem supplier in lvCurrentSuppliers.Items){                        
                        int supplierid = Convert.ToInt32(supplier.SubItems[1].Text);
                        ProductDB.InsertProductToSupplier(supplierid);
                    }
                    MessageBox.Show(newProduct + " has been successfully added to the database.", "Success");
                    DialogResult = DialogResult.OK;
                }
                else{
                    MessageBox.Show(newProduct + " already exists in the database!", "Error");

                }
                }//Validator is present
            }//button ok click



        //METHOD FOR Confirming if the product is in the database or not
        private static bool ConfirmDuplicateProduct(string newProduct, List<Product> allProducts)
        {

            foreach (Product product in allProducts)// You can change to regular expression to grab all the instances of the product
            {
                if (product.ProdName.ToUpper() == newProduct.ToUpper())
                {
                    
                    return false;
                }

            }
            return true;
        }

        private void FrmNewProduct_Load(object sender, EventArgs e)
        {
            // on load we are refreshing the datasource
            lbAllSuppliers.DataSource = SupplierDB.GetAllSuppliers();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductSupplier supplier = (ProductSupplier)lbAllSuppliers.SelectedItem;

            //grabbing the supplier id and supplier name to add to a listview
            //this listview will be the suppliers that you will add to the new product 
            int newSupplierID = supplier.SupplierId;
            string newSupplierName = supplier.SupName;

            string[] row = {  newSupplierName, newSupplierID.ToString() };

            var ListViewItem = new ListViewItem(row);

            lvCurrentSuppliers.Items.Add(ListViewItem);


            // refresh the suppliers datasource
            lbAllSuppliers.DataSource = GrabRemainingSupplier();


        }//BtnAdd Click



        //removing and item from the supplier
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

            //refresh the datasource using the method of remaining suppliers
            lbAllSuppliers.DataSource = GrabRemainingSupplier();
        }



        //this is a method for refreshing the datasource so there isn't any duplicates
        private List<ProductSupplier> GrabRemainingSupplier()
        {
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
            return suppliersRemaining;

        }


    }//FormProduct
    }//NameSpace



