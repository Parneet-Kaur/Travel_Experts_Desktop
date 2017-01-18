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

        }//FormProduct
    }//NameSpace



