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
    public partial class FrmLandingPage : MaterialForm
    {
        public FrmLandingPage()
        {
            InitializeComponent();
        }

        private void btnProductSuppliers_Click(object sender, EventArgs e)
        {
            FrmProductSupplierHomecs productSupplierHome = new FrmProductSupplierHomecs();
            this.Hide();
            DialogResult result = productSupplierHome.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.Show();
            }
         
        }

        private void FrmLandingPage_Load(object sender, EventArgs e)
        {
            Login login = new TravelExpertsDb.Login();
            DialogResult result = login.ShowDialog();
        }

        private void BtnPackages_Click(object sender, EventArgs e)
        {
            FrmAddPackage newPackage = new FrmAddPackage();
            DialogResult result = newPackage.ShowDialog();
        }
    }
}
