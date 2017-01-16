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
    public partial class FrmEditProduct : MaterialForm
    {
        public int productIndex = 0; //grabbing the product index to display on the page 

        public FrmEditProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEditProduct_Load(object sender, EventArgs e)
        {
            //Attach a data to the products listbox
            lbProduct.DataSource = ProductDB.GetProducts();//Returns a list of products
            lbProduct.DisplayMember = "ProdName";
            lbProduct.ValueMember = "ProductId";

            
            lbProduct.SelectedIndex = productIndex; //passing on the index from the landing page.. if there is an error on the main page then the 
            //value default is air.

            txtNewProduct.Focus();//MATERIAL SKIN DOESNT LET YOU FOCUS
        }

        private void lbProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            Product selectedProduct = (Product) lbProduct.SelectedItem;
            txtCurrentProductName.Text = selectedProduct.ProdName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           Product editProduct = (Product)lbProduct.SelectedItem;

            if (Validator.IsPresent(txtNewProduct))
            {
                string newProductName = txtNewProduct.Text;

                //update the database for the supplier
                ProductDB.UpdateProductName(editProduct, newProductName);
                MessageBox.Show(editProduct.ProdName + " has been changed to " + newProductName, "Success");
                DialogResult = DialogResult.OK;


            }
            else
            {
                MessageBox.Show(editProduct.ProdName + " has been updated already. Please refresh the database", "Error");
                DialogResult = DialogResult.Retry;
            }
        }
    }
}
