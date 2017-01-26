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
using TravelExpertsDb.Forms;

namespace TravelExpertsDb
    //Parneet Kuar
{
    public partial class DefaultPackages : MaterialForm
    {
        public DefaultPackages()
        {
            InitializeComponent();
        }


        //once the addpackage is created the dialog box shows of the add package
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            FrmAddPackage addPackage = new FrmAddPackage();
            
            DialogResult result = addPackage.ShowDialog();
            if (result == DialogResult.OK)// if the package has been successfully added then we can refresh the datasource

            {
                //Here we are refreshing the datasource
                dtgPackages.DataSource = PackagesDb.GetAllPackages();

            }
        }


        // opening the update package form 
        private void btnUpdatePackage_Click(object sender, EventArgs e)
        {
            UpdatePackage updatePackage = new UpdatePackage();
            
            DialogResult result = updatePackage.ShowDialog();
            if (result == DialogResult.OK)
            {
                //refreshing the datasource
                dtgPackages.DataSource = PackagesDb.GetAllPackages();
            }

        }


        private void DefaultPackages_Load(object sender, EventArgs e)
        {
            //on the load we are refreshing the datasource
            dtgPackages.DataSource = PackagesDb.GetAllPackages();
            this.dtgPackages.Columns["PkgBasePrice"].DefaultCellStyle.Format = "c";
            this.dtgPackages.Columns["PkgAgencyCommission"].DefaultCellStyle.Format = "c";
        }

        private void DefaultPackages_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK; // when we close the form... we go back to the landing page
        }
    }
}
