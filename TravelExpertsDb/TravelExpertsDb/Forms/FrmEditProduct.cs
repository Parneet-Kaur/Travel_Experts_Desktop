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
    //Ami Umeda, Callias Nguyen
    //
    //January 12, 2017
    //
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


        //every time the product has changed the text will change with that associated product
        private void lbProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            Product selectedProduct = (Product) lbProduct.SelectedItem;
            txtCurrentProductName.Text = selectedProduct.ProdName;
        }


        //when we click save we are changing the product name
        private void btnSave_Click(object sender, EventArgs e)
        {
           Product editProduct = (Product)lbProduct.SelectedItem;

            if (Validator.IsPresent(txtNewProduct)) //if there is a name present pass through
            {
                string newProductName = txtNewProduct.Text;

                //update the database for the supplier
                ProductDB.UpdateProductName(editProduct, newProductName);
                MessageBox.Show(editProduct.ProdName + " has been changed to " + newProductName, "Success");
                DialogResult = DialogResult.OK;


            }
            else
            {
             //do nothing... the messagebox will show up via the validator....
            }
        }
    }
}
