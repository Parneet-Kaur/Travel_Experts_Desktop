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
    public partial class PackagesUpdate :MaterialForm
    {
        public PackagesUpdate()
        {
            InitializeComponent();
        }

        private void PackagesUpdate_Load(object sender, EventArgs e)
        {
            cbPkgName.DataSource = PackagesDb.getPackageIDs();
            cbPkgName.DisplayMember = "pkgName";
            cbPkgName.ValueMember = "pkgID";
        }
    }
}
