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
    public partial class PackagesUI : MaterialForm
    {
        public PackagesUI()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Packages Package = new Packages();
            // ValidatorPackages validator = new ValidatorPackages();
            if (cbPackageName.SelectedText.ToString() != null)
            {
                var package = (DataRowView)cbPackageName.SelectedItem;
                string packageName = package["PkgName"].ToString();
                int packageId = (int)package["PackageId"];
                Package.PkgName = packageName;
                Package.PackageID = packageId;
            }
            else
            {
                MessageBox.Show("Please select a value.");
            }



            if (ckbStartDate.Checked)
            {
                Package.PkgStartDate = DateTime.MinValue;
            }
            else
            {
                Package.PkgStartDate = dtpStartDate.Value;
            }


            if (ckbEndDate.Checked)
            {
                Package.PkgEndDate = DateTime.MinValue;
            }
            else
            {
                Package.PkgEndDate = dtpStartDate.Value;
            }


            Package.PkgDesc = rtbDescription.Text;
            //to validate base price and assign it to package
            if (ValidatorPackages.isEmpty(txtPackageBasePrice))
            {
                MessageBox.Show("Base Price can not be empty.");
            }
            else
            {
                Package.PkgBasePrice = ValidatorPackages.isDecimal(txtPackageBasePrice);
            }

            Package.PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommision.Text);

            int success = PackagesDb.updatePackage(Package);
            if (success >= 1)
            {

                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("update failed");
            }

        }//end of function button clicked

        private void PackagesUI_Load(object sender, EventArgs e)
        {
            cbPackageName.DataSource = PackagesDb.getPackageIDs();
            // List<int> pkgId = new List <int>();

            cbPackageName.DisplayMember = "PkgName";
            cbPackageName.ValueMember = "PackageId";

            // Packages package = PackagesDb.getPackage(Convert.ToInt16(cbPackageName.SelectedValue));
            Packages package = null;
            package = PackagesDb.getPackage(Convert.ToInt16(cbPackageName.SelectedValue));
            dtpStartDate.Value = package.PkgStartDate;
            dtpEnddate.Value = package.PkgEndDate;
            rtbDescription.Text = package.PkgDesc;
            txtPackageBasePrice.Text = package.PkgBasePrice.ToString();
            txtAgencyCommision.Text = package.PkgAgencyCommission.ToString();

            //******************get dates from db********
            if (package.PkgStartDate == DateTime.MinValue)
            {
                dtpStartDate.CustomFormat = " ";
                dtpStartDate.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtpStartDate.Format = DateTimePickerFormat.Long;
                dtpStartDate.Value = package.PkgStartDate;

            }
            if (package.PkgEndDate == DateTime.MinValue)
            {
                dtpEnddate.CustomFormat = " ";
                dtpEnddate.Format = DateTimePickerFormat.Custom;

            }
            else
            {
                dtpEnddate.Format = DateTimePickerFormat.Long;
                dtpEnddate.Value = package.PkgEndDate;

            }

        }//end of form load function

        private void cbPackageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Packages pack = null;
            string ID = cbPackageName.SelectedValue.ToString();
            var package = (DataRowView)cbPackageName.SelectedItem;
            string packageName = package["PkgName"].ToString();
            int packageId = (int)package["PackageId"];

            // MessageBox.Show(packageName + packageId);

            pack = PackagesDb.getPackage(packageId);
            dtpStartDate.Value = pack.PkgStartDate;
            dtpEnddate.Value = pack.PkgEndDate;
            rtbDescription.Text = pack.PkgDesc;
            txtPackageBasePrice.Text = pack.PkgBasePrice.ToString();
            txtAgencyCommision.Text = pack.PkgAgencyCommission.ToString();

        }
    }
}
