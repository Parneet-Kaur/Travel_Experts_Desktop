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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
            if (Validator.IsPresent(txtNewSupplierName))
            {
                string newSupplierName = (txtNewSupplierName.Text).ToUpper(); //Change the new name to all uppercase like the Database

                if (SupplierDB.AddNewSupplier(newSupplierName))
                {
                    MessageBox.Show(newSupplierName + " has been successfully been added to the database", "Success");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Supplier " + newSupplierName + " already exists!", "Error");
                    DialogResult = DialogResult.Retry;
                }
            }
        }
    }
}
