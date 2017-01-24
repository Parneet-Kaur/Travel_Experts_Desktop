﻿using MaterialSkin.Controls;
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
    public partial class UpdatePackage : MaterialForm
    {
        public UpdatePackage()
        {
            InitializeComponent();
        }

        private void UpdatePackage_Load(object sender, EventArgs e)
        {

            //populate combobox for products
            cbProducts.DataSource = PackagesDb.GetProducts();
            cbProducts.DisplayMember = "ProdName";
            cbProducts.ValueMember = "ProductId";

            //populating combobox for packages
            cbPackageName.DataSource = PackagesDb.getPackageIDs();
            cbPackageName.DisplayMember = "PkgName";
            cbPackageName.ValueMember = "PackageId";

            Packages package = null;
            package = PackagesDb.getPackage(Convert.ToInt16(cbPackageName.SelectedValue));
            dtpStartDate.Value = package.PkgStartDate;
            dtpEndDate.Value = package.PkgEndDate;
            rtbPkgDesc.Text = package.PkgDesc;
            txtPkgBasePrice.Text = package.PkgBasePrice.ToString();
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
                dtpEndDate.CustomFormat = " ";
                dtpEndDate.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtpEndDate.Format = DateTimePickerFormat.Long;
                dtpEndDate.Value = package.PkgEndDate;
            }

            //populate listview for package deatils
            List<PackageProductDetails> ppd = new List<PackageProductDetails>();
            ppd = PackagesDb.GetPackageProductDetails(Convert.ToInt16(cbPackageName.SelectedValue));
            foreach (var item in ppd)
            {

                lvPackageDetails.Items.Add(new ListViewItem(new string[] { item.prodName, item.supplierName }));
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

        private void cbPackageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Packages pack = null;
            string ID = cbPackageName.SelectedValue.ToString();
            var package = (DataRowView)cbPackageName.SelectedItem;
            string packageName = package["PkgName"].ToString();
            int packageId = (int)package["PackageId"];

            pack = PackagesDb.getPackage(packageId);
            dtpStartDate.Value = pack.PkgStartDate;
            dtpEndDate.Value = pack.PkgEndDate;
            rtbPkgDesc.Text = pack.PkgDesc;
            txtPkgBasePrice.Text = pack.PkgBasePrice.ToString();
            txtAgencyCommision.Text = pack.PkgAgencyCommission.ToString();

            //populate listbox for products
            lvPackageDetails.Items.Clear();
            if (cbPackageName.Focused == true)
            {
                List<PackageProductDetails> ppd = new List<PackageProductDetails>();
                ppd = PackagesDb.GetPackageProductDetails(packageId);
                foreach (var item in ppd)
                {
                    lvPackageDetails.Items.Add(new ListViewItem(new string[] { item.prodName, item.supplierName }));
                }
                lvPackageDetails.Refresh();
            }
            lvSelectProductSupplier.Items.Clear();

        }//end of function

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducts.Focused == true)
            {
                var product = (DataRowView)cbPackageName.SelectedItem;
                int temp = Convert.ToInt16(cbProducts.SelectedValue);
                List<Supplier> sup = new List<Supplier>();

                sup = PackagesDb.GetAllSupplier(temp);
                lbSuppliers.Items.Clear();
                foreach (var item in sup)
                {
                    lbSuppliers.Items.Add(item);
                    lbSuppliers.DisplayMember = "SupName";
                }
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

        }// end of function

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvSelectProductSupplier.SelectedItems == null)
            {
                MessageBox.Show("Please select one of the items in the box.");
            }
            //************if the btn is clicked and there are no enteries in lv
            else
            {
                foreach (ListViewItem item in lvSelectProductSupplier.SelectedItems){
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

        private void btnUpdatePkg_Click(object sender, EventArgs e)
        {
            Packages Package = new Packages();
           
            if (cbPackageName.SelectedText.ToString() != null){
                var package = (DataRowView)cbPackageName.SelectedItem;
                string packageName = package["PkgName"].ToString();
                int packageId = (int)package["PackageId"];
                Package.PkgName = packageName;
                Package.PackageID = packageId;
            }
            else{
                MessageBox.Show("Please select a value.");
            }

            if (ckbStartDate.Checked){
                Package.PkgStartDate = DateTime.MinValue;
            }
            else{
                Package.PkgStartDate = dtpStartDate.Value;
            }
            if (ckbEndDate.Checked){
                Package.PkgEndDate = DateTime.MinValue;
            }
            else{
                Package.PkgEndDate = dtpStartDate.Value;
            }
            Package.PkgDesc = rtbPkgDesc.Text;
            //to validate base price and assign it to package
            if (ValidatorPackages.isEmpty(txtPkgBasePrice))
            {
                MessageBox.Show("Base Price can not be empty.");
            }
            else
            {
                Package.PkgBasePrice = ValidatorPackages.isDecimal(txtPkgBasePrice);
            }

            Package.PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommision.Text);

            int success = PackagesDb.updatePackage(Package);
            if (success >= 1)
            {
                //update changes to packageProductSupplier table
                foreach (ListViewItem item in lvSelectProductSupplier.Items)
                {

                    int psi = Convert.ToInt16(item.SubItems[2].Text);


                    int result = PackagesDb.addProductSupplierToPackage(psi, Package.PackageID);
                }

                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }




            //populate listview for products
            lvPackageDetails.Items.Clear();
            List<PackageProductDetails> ppd = new List<PackageProductDetails>();
            ppd = PackagesDb.GetPackageProductDetails(Convert.ToInt16(cbPackageName.SelectedValue));
            foreach (var item in ppd)
            {

                lvPackageDetails.Items.Add(new ListViewItem(new string[] { item.prodName, item.supplierName }));
            }


            lvSelectProductSupplier.Items.Clear();
        }
    }
}
