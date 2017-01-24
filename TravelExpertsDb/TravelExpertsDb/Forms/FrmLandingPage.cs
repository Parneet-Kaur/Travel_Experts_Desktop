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
{// This is the initial landing page for the website... where it will redirect the users to the 
    // the packages and products/suppliers...
    
    public partial class FrmLandingPage : MaterialForm
    {
        


        public FrmLandingPage()
        {
            InitializeComponent();
         
        }




        private void FrmLandingPage_Load(object sender, EventArgs e)
        {
            Login login = new TravelExpertsDb.Login();
            DialogResult result = login.ShowDialog();
        }


        private void btnPackages_Click(object sender, EventArgs e)
        {
            FrmAddPackage newPackage = new FrmAddPackage();
            DialogResult result = newPackage.ShowDialog();
        }

        private void btnProductSuppliers_Click_1(object sender, EventArgs e)
        {
            FrmProductSupplierHomecs productSupplierHome = new FrmProductSupplierHomecs();
            this.Hide();
            DialogResult result = productSupplierHome.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();

            }

        }
    }
}
