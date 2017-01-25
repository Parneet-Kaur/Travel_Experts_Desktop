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
    //Callias Nguyen, Parneet
    
    public partial class FrmLandingPage : MaterialForm
    {
        


        public FrmLandingPage()
        {
            InitializeComponent();
         
        }



        // on the load we have the child element LOGIN show up so that way we force the user to login
        private void FrmLandingPage_Load(object sender, EventArgs e)
        {
            Login login = new TravelExpertsDb.Login();
            DialogResult result = login.ShowDialog();
        }

        //button for clicking the packages
        private void btnPackages_Click(object sender, EventArgs e)
        {
            DefaultPackages PackageLandingPage = new DefaultPackages();
            this.Hide();
            DialogResult result = PackageLandingPage.ShowDialog();
      
            if (result == DialogResult.OK)
            {
                this.Show();

            }
        }

        //button to go to the productsuppliers side
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


        // when the form closes the landing page shows up again

        private void FrmLandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
