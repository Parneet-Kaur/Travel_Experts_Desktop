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
{// Callias Nguyen
    // Ami Umeda
    public partial class FrmEditProductSuppliers : MaterialForm
    {
        public FrmEditProductSuppliers()
        {
            InitializeComponent();
        }

        private void FrmEditProductSuppliers_Load(object sender, EventArgs e)
        {
            lbProducts.DataSource = ProductDB.GetProducts(); // load the listbox with products

        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)lbProducts.SelectedItem;

           List<ProductSupplier> productsSupplier  = selectedProduct.GetSuppliers();//refresh the product's suppliers
            lbCurrentSuppliers.DataSource = productsSupplier;//refresh the product's suppliers

            List<ProductSupplier> remainingProductSupplier = selectedProduct.GetRemainingSuppliers();
            if (productsSupplier.Count != 0)// if this listbox is not empty
            {
                lbAllSuppliers.DataSource = remainingProductSupplier; //refresh the all suppliers
                btnRemove.Enabled = true;
            }
            else
            {// if the listbox is empty we want to disable buttons so the user does not crash the program
                lbAllSuppliers.DataSource = remainingProductSupplier;
                btnRemove.Enabled = false;
            }
            //Display the product for the attached suppliers
            lblProductSuppliers.Text = "Current Suppliers for " + selectedProduct.ProdName;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //grabbing the classes to delete
            Product product = (Product)lbProducts.SelectedItem;
            ProductSupplier productsupplier = (ProductSupplier)lbCurrentSuppliers.SelectedValue;

            //Delete the supplier from the product
            ProductDB.RemoveProductsSupplier(product, productsupplier);

            //Refresh the Dataset
         
            lbAllSuppliers.DataSource = ProductDB.GetSuppliersNotInProduct(product);

         

            List<ProductSupplier> remainingProductSupplier = ProductDB.GetProductSuppliers(product);
            if (remainingProductSupplier.Count != 0)
            {
                lbCurrentSuppliers.DataSource = remainingProductSupplier; //refresh the all suppliers
                btnRemove.Enabled = true;
            }
            else
            {
                lbCurrentSuppliers.DataSource = remainingProductSupplier;
                btnRemove.Enabled = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //grabbing the classes to add
            Product product = (Product)lbProducts.SelectedItem;
            ProductSupplier productsupplier = (ProductSupplier)lbAllSuppliers.SelectedValue;


            //Add Supplier to product
            ProductDB.AddSuppliertoProduct(product, productsupplier);

            //Refresh the Dataset
            lbCurrentSuppliers.DataSource = ProductDB.GetProductSuppliers(product);

            lbAllSuppliers.DataSource = ProductDB.GetSuppliersNotInProduct(product);

            List<ProductSupplier> remainingProductSupplier = ProductDB.GetProductSuppliers(product);
            if (remainingProductSupplier.Count != 0)
            {
                lbCurrentSuppliers.DataSource = remainingProductSupplier; //refresh the all suppliers
                btnRemove.Enabled = true;
            }
            else
            {
                lbCurrentSuppliers.DataSource = remainingProductSupplier;
                btnRemove.Enabled = false;
            }
        }


        private void lbCurrentSuppliers_SelectedValueChanged(object sender, EventArgs e)
        {
            //Display the packages that are being used for the current suppliers
            ProductSupplier currentSupplier = (ProductSupplier)lbCurrentSuppliers.SelectedItem;
            List<string> currentPackages = SupplierDB.AttachedPackagesFromSuppliers(currentSupplier);

            if (currentPackages != null)
            {
                lbPackages.DataSource = currentPackages;
            }
        }
    }
}
