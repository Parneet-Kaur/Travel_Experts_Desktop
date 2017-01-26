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
{//Parneet
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
                MessageBox.Show("Please select one of the items in the box.","Error");
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
            Packages Package = new Packages();
            if (ValidatorPackages.isEmpty(txtPackageName))
            {
                MessageBox.Show("Please provide a name for the package.");
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
            decimal temp;
            if (Decimal.TryParse(txtPkgBasePrice.Text, out temp))
            {
                Package.PkgAgencyCommission = Convert.ToDecimal(temp);

            }
            else
            {
                Package.PkgAgencyCommission = null;
            }




            if (PackagesDb.AddPackage(Package) >= 1)
                 {
                    MessageBox.Show("This package was successfully added");
                   }             

               else if (PackagesDb.AddPackage(Package) == 1)
                {
                    foreach (ListViewItem item in lvSelectProductSupplier.Items)
                    {
                        int psi = Convert.ToInt16(item.SubItems[2].Text);
                        int result = PackagesDb.AddPackageDetails(psi);

                        if (result >= 1)
                        {
                            // we let foreach run for all items before displaying success message
                        }
                        else
                        {
                            MessageBox.Show("The package was successfully added but an error was encountered while entering package details.");
                        }
                    }//end of foreach
                    MessageBox.Show(" This package was successfully added with all its details");

                }
                //else
                //{
                //    MessageBox.Show(" Package could not be added. Please contact support.");
                //}
                //populate listview for products
          
                List<PackageProductDetails> ppd = new List<PackageProductDetails>();

                foreach (ListViewItem item in lvSelectProductSupplier.Items)
                {
                    //  lvPackageDetails.Items.Add(item);//generating exception here
                }

                lvSelectProductSupplier.Items.Clear();
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }


    }

