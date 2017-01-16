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

                if (ProductDB.AddNewProduct(newProduct))
                {
                    MessageBox.Show(newProduct + " has been successfully added to the database.", "Success");
                    DialogResult = DialogResult.OK;
                }
                else {
                    MessageBox.Show(newProduct + " already exists in the database!", "Error");
                    DialogResult = DialogResult.Retry;

                }
            }
        }
    }
}
