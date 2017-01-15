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
    public partial class FrmEditSupplier : MaterialForm

    {
        public FrmEditSupplier()
        {
            InitializeComponent();
        }

        private void FrmEditSupplier_Load(object sender, EventArgs e)
        {
            lbSuppliers.DataSource = SupplierDB.GetAllSuppliers();
        }

        private void lbSuppliers_SelectedValueChanged(object sender, EventArgs e)
        {
            ProductSupplier editSupplier = (ProductSupplier)lbSuppliers.SelectedItem;
            txtCurrentSuppliersID.Text = editSupplier.SupName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

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
            else
            {
                MessageBox.Show(editSupplier.SupName + " has been updated already. Please refresh the database", "Error");
                DialogResult = DialogResult.Retry;
            }
                


        }
    }
}
