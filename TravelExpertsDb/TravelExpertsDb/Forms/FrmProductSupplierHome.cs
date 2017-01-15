using System;
using MaterialSkin.Controls;
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
    public partial class FrmProductSupplierHomecs : MaterialForm
    {
        public FrmProductSupplierHomecs()
        {
            InitializeComponent();
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            FrmNewSupplier newSupplierForm = new FrmNewSupplier();
            DialogResult result = newSupplierForm.ShowDialog();
            if(result == DialogResult.OK)
            {

            }
        }

        private void FrmProductSupplierHomecs_Load(object sender, EventArgs e)
        {
            //Once the form loads we want to load the products that we have
            cboProduct.DataSource = ProductDB.GetProducts();

        }

        private void cboProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)cboProduct.SelectedValue;
            lbCurrentSuppliers.DataSource = ProductDB.GetProductSuppliers(selectedProduct);

        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            FrmNewProduct newProductForm = new FrmNewProduct();
            DialogResult result = newProductForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                cboProduct.DataSource = ProductDB.GetProducts();
            }

        }


        private void btnEditProductSupplier_Click(object sender, EventArgs e)
        {
            FrmEditProductSuppliers newProductSuppliers = new FrmEditProductSuppliers();
            DialogResult result = newProductSuppliers.ShowDialog();
            if (result == DialogResult.OK)
            {
                cboProduct.DataSource = ProductDB.GetProducts();
            }
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            FrmEditSupplier editSupplier = new FrmEditSupplier();
            DialogResult result = editSupplier.ShowDialog();
            if (result == DialogResult.OK)
            {
                cboProduct.DataSource = ProductDB.GetProducts();
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            FrmEditProduct editProduct = new FrmEditProduct();
            DialogResult result = editProduct.ShowDialog();
            if(result == DialogResult.OK)
            {
                cboProduct.DataSource = ProductDB.GetProducts();
            }
        }
    }
}
