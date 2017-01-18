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
    public partial class FrmNewSupplier : MaterialForm
    {
        public FrmNewSupplier()
        {
            InitializeComponent();
        }


        //Cannot actually focus on the text.... for material skin so i didn't bother implementing a focus here

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
            if (Validator.IsPresent(txtNewSupplierName))
            {
                string newSupplierName = (txtNewSupplierName.Text).ToUpper(); //Change the new name to all uppercase like the Database

                if (ConfirmNewSupplier(newSupplierName))//confirming if the supplier is in the database or not....
                {

                    if (SupplierDB.AddNewSupplier(newSupplierName))// inserting the supplier into the database
                    {
                        MessageBox.Show(newSupplierName + " has been successfully been added to the database", "Success");
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show(newSupplierName + " is already in the database", "Failure");
                }
            }
        }//btn Ok Click


        private static bool ConfirmNewSupplier(string newSupplier)
        {
            List<ProductSupplier> allSuppliers = SupplierDB.GetAllSuppliers();

            foreach (ProductSupplier supplier in allSuppliers)
            {
                if(supplier.SupName == newSupplier)
                {
                    return false;
                }
                
            }
            return true;

        }

    }//FrmSupplier
}
