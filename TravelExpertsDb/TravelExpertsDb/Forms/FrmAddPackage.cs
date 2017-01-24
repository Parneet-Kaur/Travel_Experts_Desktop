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
using TravelExpertsDb.Data;
using TravelExpertsDb.Entity;

namespace TravelExpertsDb.Forms
{// Parneet

    public partial class FrmAddPackage : MaterialForm
    {
        public FrmAddPackage()
        {
            InitializeComponent();
        }

        private void FrmAddPackage_Load(object sender, EventArgs e)
        {
            //load the product datasource when the form first loads
            cboProduct.DataSource = ProductDB.GetProducts();
        }

        private void cboProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            //need to create an if statement for when the list contains no values.....
            //Grab a list of all the suppliers associated with the product EXCLUDING the ones you
            //want to add to the package
            //refresh the datasource for the suppliers attached to the product
            List<ProductSupplier> remainingSuppliers = RemainingSuppliersforProduct();
            if (remainingSuppliers.Count != 0)
            {
                lbSuppliers.DataSource = remainingSuppliers;
                btnAdd.Enabled = true;
            }
            else
            {
                lbSuppliers.DataSource = remainingSuppliers;
                btnAdd.Enabled = false;// disable the add button when there is nothing in the suppliers listbox
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {     //grabbing all the information on the selected product and supplier that you want for the package
            Product selectedProduct = (Product)cboProduct.SelectedItem;
            ProductSupplier selectedSupplier = (ProductSupplier)lbSuppliers.SelectedItem;

            // creating a new listview Item (to add to the listview package product supplier( everytime you add another product and supplier

            string newProduct = selectedProduct.ProdName;
            string newSupplier = selectedSupplier.SupName;
            int newProductSupplierId = selectedSupplier.ProductSupplierId;

            string[] row = { newProduct, newSupplier, newProductSupplierId.ToString() };

            var listViewItem = new ListViewItem(row);
            lvPackageProductSuppliers.Items.Add(listViewItem);

            //refresh the datasource for the suppliers attached to the product
            List<ProductSupplier> remainingSuppliers = RemainingSuppliersforProduct();


            //Checking to see if the count of the List<> is 0, and if it is the btn adding will be disabled
            //will refresh the datasource regardless
            if (remainingSuppliers.Count != 0)
            {
                lbSuppliers.DataSource = remainingSuppliers;
                btnAdd.Enabled = true;

            }
            else
            {
                lbSuppliers.DataSource = remainingSuppliers;
                btnAdd.Enabled = false;
            }
        }// end of function




        //A method to grab a list of all the suppliers associated with the product EXCLUDING the ones you
        //want to add to the package
        private List<ProductSupplier> RemainingSuppliersforProduct()
       {
            //Grabbing the Product class to grab its suppliers
            Product selectedProduct = (Product)cboProduct.SelectedItem;

            //grab a list of the suppliers associated for that product
            List<ProductSupplier> SuppliersForProduct = ProductDB.GetProductSuppliers(selectedProduct);
            //grab a List of listview items (these are items we want for this package)
            //that we do not want to contain in the suppliers attached to a product (Using Linq)
            List<int> productSupplierIds = new List<int>();

            foreach (ListViewItem item in lvPackageProductSuppliers.Items)
            {
                int productSupplierId = Convert.ToInt32(item.SubItems[2].Text);
                productSupplierIds.Add(productSupplierId); // adding this to the list of suppliers for the product

            }

            var suppliersNotIn = from supplier in SuppliersForProduct
                                 where !(productSupplierIds.Any(packagesupplier => packagesupplier == supplier.ProductSupplierId))
                                 select supplier;

            List<ProductSupplier> suppliersRemaining = new List<ProductSupplier>();//second list for keeping track of remaining supplier  
            foreach (var supplier in suppliersNotIn)
            {
                suppliersRemaining.Add(supplier);
            }

            return suppliersRemaining;
        }




        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPackageProductSuppliers.SelectedItems)
            {
                lvPackageProductSuppliers.Items.Remove(item);
            }


            //refresh the datasource for the suppliers attached to the product
            List<ProductSupplier> remainingSuppliers = RemainingSuppliersforProduct();
            lbSuppliers.DataSource = remainingSuppliers;//what are u doing here??; redundant code

            //the list of remaining supplier is empty 
            if (remainingSuppliers.Count != 0)
            {
             
                btnAdd.Enabled = true;
            }
            else
            {
      
                btnAdd.Enabled = false;
            }

        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (ValidData())//validating all text fields
            {

                Package newPackage = new Package();

                newPackage.PkgName = Convert.ToString(txtPackageName.Text);
                newPackage.PkgStartDate = dtpStartDate.Value;
                newPackage.PkgEndDate = dtpEndDate.Value;
                newPackage.PkgDesc = Convert.ToString(txtDescription.Text);
                newPackage.PkgBasePrice = Convert.ToDouble(txtBasePrice.Text);
                newPackage.PkgAgencyCommission = Convert.ToDouble(txtCommission.Text);


                if (PackageDB.AddNewPackage(newPackage))
                {
                    MessageBox.Show("Package has been inserted into the database!", "Success");
                }
                else
                {
                    MessageBox.Show("Error in the database", "Error");
                }


                foreach (ListViewItem item in lvPackageProductSuppliers.Items)
                {
                    int newProductSupplierId = Convert.ToInt32(item.SubItems[2].Text);

                    if (PackageDB.AddNewProductSupplierToPackage(newProductSupplierId))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Error with this supplier", "Database Error");
                    }
                }
                DialogResult = DialogResult.OK;
            }//validating data
          

        }//btnaccept


         private bool ValidData()
            {
                return
                Validator.IsPresent(txtPackageName) &&
                 Validator.ValidDate(dtpStartDate.Value, dtpEndDate.Value) &&
                  Validator.IsPresent(txtDescription) && 
                Validator.IsPresent(txtBasePrice) &&
                Validator.IsDecimal(txtBasePrice) &&
                Validator.IsWithinRange(txtBasePrice, 0, 100000) &&
                Validator.IsPresent(txtCommission) &&
                Validator.IsDecimal(txtCommission) &&
                Validator.IsWithinRange(txtCommission, 0, 100000) &&

                 Validator.CommissionBasePriceCheck(Convert.ToDecimal(txtBasePrice.Text), Convert.ToDecimal(txtCommission.Text));

            }
    
    }
}
