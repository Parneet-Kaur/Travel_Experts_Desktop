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

namespace TravelExpertsDb
{
    public partial class DefaultPackages : MaterialForm
    {
        public DefaultPackages()
        {
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            AddPackage addPackage = new AddPackage();
            this.Hide();
            DialogResult result = addPackage.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();

            }
        }

        private void btnUpdatePackage_Click(object sender, EventArgs e)
        {
            UpdatePackage updatePackage = new UpdatePackage();
            this.Hide();
            DialogResult result =updatePackage .ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();

            }

        }

        private void DefaultPackages_Load(object sender, EventArgs e)
        {
            dtgPackages.DataSource = PackagesDb.GetAllPackages();
        }
    }
}
