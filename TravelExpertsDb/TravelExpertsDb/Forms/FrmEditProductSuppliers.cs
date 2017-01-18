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
            lbCurrentSuppliers.DataSource = selectedProduct.GetSuppliers();//refresh the product's suppliers
            lbAllSuppliers.DataSource = selectedProduct.GetRemainingSuppliers(); //refresh the all suppliers

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
            lbCurrentSuppliers.DataSource = ProductDB.GetProductSuppliers(product);
            lbAllSuppliers.DataSource = ProductDB.GetSuppliersNotInProduct(product);

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
