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
    public partial class AddPackage : MaterialForm
    {
        public AddPackage()
        {
            InitializeComponent();
        }

        private void AddPackage_Load(object sender, EventArgs e)
        {
            //populate combobox for products
            cbProducts.DataSource = PackagesDb.GetProducts();
            cbProducts.DisplayMember = "ProdName";
            cbProducts.ValueMember = "ProductId";

            //populate listbox for suppliers for a certain product
            List<Supplier> sup = new List<Supplier>();
            sup = PackagesDb.GetAllSupplier(Convert.ToInt16(cbProducts.SelectedValue));
            foreach (var item in sup)
            {
                lbSuppliers.Items.Add(item);
                lbSuppliers.DisplayMember = "SupName";
                // lbSuppliers.ValueMember = "SupplierId"; 
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbSuppliers.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier.");
            }

            else
            {
                Supplier s1 = (Supplier)lbSuppliers.SelectedItem;
                string supplier = s1.SupName;
                Product p = (Product)cbProducts.SelectedItem;
                string product = p.ProdName;
                string productSupplierId = s1.ProductSupplierId.ToString();
                ListViewItem lvi = new ListViewItem(new string[] { product, supplier, productSupplierId });
                lvSelectProductSupplier.Items.Add(lvi);
                lbSuppliers.Items.Remove(lbSuppliers.SelectedItem);

            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvSelectProductSupplier.SelectedItems == null)
            {
                MessageBox.Show("Please select one of the items in the box.");
            }
            //************if the btn is clicked and there are no enteries in lv
            else
            {
                foreach (ListViewItem item in lvSelectProductSupplier.SelectedItems)
                {
                    lvSelectProductSupplier.Items.Remove(item);

                }
                //populate listbox for suppliers for a certain product
                List<Supplier> sup = new List<Supplier>();
                sup = PackagesDb.GetAllSupplier(Convert.ToInt16(cbProducts.SelectedValue));
                foreach (var item in sup)
                {
                    lbSuppliers.Items.Add(item);
                    lbSuppliers.DisplayMember = "SupName";
                    // lbSuppliers.ValueMember = "SupplierId"; 
                }

            }
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            DateTime tempStartDate;
            DateTime tempEndDate;
            Packages Package = new Packages();
                    if(Package==null){
                MessageBox.Show("Please add data first.");
            }

            if (ValidatorPackages.IsValidData(txtPackageName,dtpStartDate.Value,dtpEndDate.Value,txtPkgBasePrice)) {
                MessageBox.Show("take a deepbreath");
                Package.PkgBasePrice = ValidatorPackages.isDecimal(txtPkgBasePrice);
                Package.PkgBasePrice = ValidatorPackages.isDecimal(txtAgencyCommision);
                Package.PkgName = txtPackageName.Text;
                Package.PkgStartDate = dtpStartDate.Value;
                Package.PkgEndDate = dtpEndDate.Value;
                Package.PkgDesc = rtbPkgDesc.Text;

                    if (lvPackageDetails.SelectedItems == null)
                    {
                   
                        int success = PackagesDb.AddPackage(Package);
                        if (success >= 1)
                        {
                            MessageBox.Show(" This package was successfully added");
                        }
                        else
                        {
                            MessageBox.Show(" Package could not be added. Please contact support.");
                        }
                    }// endofinnerif

                if (lvPackageDetails.SelectedItems != null) // if the user  wants to add products and suppliers as well                
                {
                    int success = PackagesDb.AddPackage(Package);

                    if (success == 1)
                    {
                        foreach (ListViewItem item in lvSelectProductSupplier.Items)
                        {
                            int psi = Convert.ToInt16(item.SubItems[2].Text);
                            int result = PackagesDb.AddPackageDetails(psi);

                            if (result >= 1)
                            {
                                // we let foreach run for all items before displaying success message
                                MessageBox.Show(" This package was successfully added with all its details");
                            }
                            else
                            {
                                MessageBox.Show("The package was successfully added but an error was encountered while entering package details.");
                            }
                        }//end of foreach

                    } //end of if             

                }// endofinnerelse
               
               
                
            }// end of is valid data


        }//endof button click
        
    }
}
