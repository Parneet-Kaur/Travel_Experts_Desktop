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
{//Callias Nguyen, Ami Umeda
    public partial class FrmEditSupplier : MaterialForm

    {
        public ProductSupplier selectedProductSupplier;

        public FrmEditSupplier()
        {
            InitializeComponent();
        }


        private void FrmEditSupplier_Load(object sender, EventArgs e)
        {//updating all the supplier to choose from in a list
            List<ProductSupplier> allSuppliers = SupplierDB.GetAllSuppliers();


            //refreshing the datasource
            lbSuppliers.DataSource = allSuppliers; 
            lbSuppliers.ValueMember = "SupName";
            lbSuppliers.DisplayMember = "SupName";

            //have to create this alogrithm to grab the supName selectedindex to post on this form
           string selectedSupplier = selectedProductSupplier.SupName;
           int i = 0;
            int supplierSelectedIndex = -1;
            foreach (ProductSupplier supplier in allSuppliers)
            {
                if(supplier.SupName == selectedSupplier )
                {
                    supplierSelectedIndex = i;
                }
                i++;
            }

            //Here we are showing the supplier we chose on the home page......
            if (supplierSelectedIndex != -1)
            {
                lbSuppliers.SelectedIndex = supplierSelectedIndex;
            }
            else
                lbSuppliers.SelectedIndex = -1;
            /////////////////////////////////////////////////////////////////////////

            //Cannot compare the indexof unless comparing Two objects...but you have to override the equals.. but also doesn't work here
            //because i did not specify the productsupplierid for these suppliers...

            //if (selectedProductSupplier != null)
            //{
            //    string selectedSupplier = selectedProductSupplier.SupName; //grabbing the supplier name
            //     int indexValueSupplier = lbSuppliers.Items.IndexOf("BONAVE"); //grabbing the index of the selected Supplier
            //    lbSuppliers.SelectedIndex = indexValueSupplier; 
            //}


            txtNewSupplier.Focus();      
            // CANT ACTUALLY FOCUS THIS MATERIAL SKIN TEXT.............
        }


        //every time the value has changed the supplier name changes to show the reflection
        private void lbSuppliers_SelectedValueChanged(object sender, EventArgs e)
        {
            ProductSupplier editSupplier = (ProductSupplier)lbSuppliers.SelectedItem;
            txtCurrentSuppliersID.Text = editSupplier.SupName;

     
        }


        //close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        //editing the save 
        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductSupplier editSupplier = (ProductSupplier)lbSuppliers.SelectedItem;

            if(Validator.IsPresent(txtNewSupplier))
            {
                string newSupplierName = txtNewSupplier.Text.ToUpper();

                //update the database for the supplier
                SupplierDB.UpdateSupplier(editSupplier, newSupplierName);
                MessageBox.Show(editSupplier.SupName + " has been changed to " + newSupplierName, "Success");
                DialogResult = DialogResult.OK;
                

            }
            
           


        }
    }
}
