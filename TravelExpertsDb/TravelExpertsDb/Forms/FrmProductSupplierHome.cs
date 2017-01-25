﻿using System;
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
  // Callias Nguyen
  // Abel Surace
  // Landing page for the whole product suppliers.....
  // opening forms via this page

    public partial class FrmProductSupplierHomecs : MaterialForm
    {

        public ProductSupplier productsupplier; //initialize a productsupplier so we can put the supplier name 
        //into the selected value
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
                //Refresh the datasource
                lballSuppliers.DataSource = SupplierDB.GetAllSuppliers();

            }
        }

        private void FrmProductSupplierHomecs_Load(object sender, EventArgs e)
        {
            //Once the form loads we want to load the products that we have
            cboProduct.DataSource = ProductDB.GetProducts();
            lballSuppliers.DataSource = SupplierDB.GetAllSuppliers();

        }


        //opening a new product form
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            FrmNewProduct newProductForm = new FrmNewProduct();         
            DialogResult result = newProductForm.ShowDialog();
            if(result == DialogResult.OK)
            {
               //refreshing the product datasource
                cboProduct.DataSource = ProductDB.GetProducts();
        
            }

        }


        //editing the product/supplier
        private void btnEditProductSupplier_Click(object sender, EventArgs e)
        {
            FrmEditProductSuppliers newProductSuppliers = new FrmEditProductSuppliers();
            DialogResult result = newProductSuppliers.ShowDialog();
            if (result == DialogResult.OK)
            {
                //refresh the datasource for products and supplier
                Product selectedProduct = (Product)cboProduct.SelectedValue;
                lballSuppliers.DataSource = ProductDB.GetProductSuppliers(selectedProduct);
                cboProduct.DataSource = ProductDB.GetProducts();

               
            }
        }


        // editing a supplier 
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            FrmEditSupplier editSupplier = new FrmEditSupplier();
            editSupplier.selectedProductSupplier = (ProductSupplier)lballSuppliers.SelectedItem; //grabbing the Productsupplier entity so that the 
            //form can focus on the selected supplier
            DialogResult result = editSupplier.ShowDialog();
            if (result == DialogResult.OK)
            {
               //update supplier
                lballSuppliers.DataSource = SupplierDB.GetAllSuppliers();
            }
        }

        // editing product 
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            
            FrmEditProduct editProduct = new FrmEditProduct();
            editProduct.productIndex = (int) cboProduct.SelectedIndex ;
            DialogResult result = editProduct.ShowDialog();
            if(result == DialogResult.OK)
            {
                cboProduct.DataSource = ProductDB.GetProducts();
            }
        }


        private void FrmProductSupplierHomecs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
