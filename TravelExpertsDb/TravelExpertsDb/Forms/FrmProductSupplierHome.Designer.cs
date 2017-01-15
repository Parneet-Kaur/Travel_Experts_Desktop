namespace TravelExpertsDb.Forms
{
    partial class FrmProductSupplierHomecs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentSuppliers = new MaterialSkin.Controls.MaterialLabel();
            this.lbCurrentSuppliers = new System.Windows.Forms.ListBox();
            this.btnNewSupplier = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNewProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditProductSupplier = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditSupplier = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(16, 96);
            this.cboProduct.MaximumSize = new System.Drawing.Size(154, 0);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(154, 21);
            this.cboProduct.TabIndex = 0;
            this.cboProduct.SelectedValueChanged += new System.EventHandler(this.cboProduct_SelectedValueChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Depth = 0;
            this.lblProduct.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProduct.Location = new System.Drawing.Point(12, 74);
            this.lblProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(133, 19);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Choose a Product:";
            // 
            // lblCurrentSuppliers
            // 
            this.lblCurrentSuppliers.AutoSize = true;
            this.lblCurrentSuppliers.Depth = 0;
            this.lblCurrentSuppliers.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCurrentSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentSuppliers.Location = new System.Drawing.Point(213, 74);
            this.lblCurrentSuppliers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentSuppliers.Name = "lblCurrentSuppliers";
            this.lblCurrentSuppliers.Size = new System.Drawing.Size(128, 19);
            this.lblCurrentSuppliers.TabIndex = 2;
            this.lblCurrentSuppliers.Text = "Current Suppliers:";
            // 
            // lbCurrentSuppliers
            // 
            this.lbCurrentSuppliers.FormattingEnabled = true;
            this.lbCurrentSuppliers.Location = new System.Drawing.Point(217, 96);
            this.lbCurrentSuppliers.Name = "lbCurrentSuppliers";
            this.lbCurrentSuppliers.Size = new System.Drawing.Size(244, 173);
            this.lbCurrentSuppliers.TabIndex = 3;
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Depth = 0;
            this.btnNewSupplier.Location = new System.Drawing.Point(217, 275);
            this.btnNewSupplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Primary = true;
            this.btnNewSupplier.Size = new System.Drawing.Size(105, 30);
            this.btnNewSupplier.TabIndex = 4;
            this.btnNewSupplier.Text = "New Supplier";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Depth = 0;
            this.btnNewProduct.Location = new System.Drawing.Point(356, 275);
            this.btnNewProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Primary = true;
            this.btnNewProduct.Size = new System.Drawing.Size(105, 30);
            this.btnNewProduct.TabIndex = 5;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnEditProductSupplier
            // 
            this.btnEditProductSupplier.Depth = 0;
            this.btnEditProductSupplier.Location = new System.Drawing.Point(16, 293);
            this.btnEditProductSupplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditProductSupplier.Name = "btnEditProductSupplier";
            this.btnEditProductSupplier.Primary = true;
            this.btnEditProductSupplier.Size = new System.Drawing.Size(154, 42);
            this.btnEditProductSupplier.TabIndex = 6;
            this.btnEditProductSupplier.Text = "Edit Product/Supplier";
            this.btnEditProductSupplier.UseVisualStyleBackColor = true;
            this.btnEditProductSupplier.Click += new System.EventHandler(this.btnEditProductSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Depth = 0;
            this.btnEditSupplier.Location = new System.Drawing.Point(217, 323);
            this.btnEditSupplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Primary = true;
            this.btnEditSupplier.Size = new System.Drawing.Size(105, 30);
            this.btnEditSupplier.TabIndex = 7;
            this.btnEditSupplier.Text = "Edit Supplier";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Depth = 0;
            this.btnEditProduct.Location = new System.Drawing.Point(356, 323);
            this.btnEditProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Primary = true;
            this.btnEditProduct.Size = new System.Drawing.Size(105, 30);
            this.btnEditProduct.TabIndex = 8;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // FrmProductSupplierHomecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 374);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnEditProductSupplier);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.btnNewSupplier);
            this.Controls.Add(this.lbCurrentSuppliers);
            this.Controls.Add(this.lblCurrentSuppliers);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cboProduct);
            this.Name = "FrmProductSupplierHomecs";
            this.Text = "Products and Suppliers";
            this.Load += new System.EventHandler(this.FrmProductSupplierHomecs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProduct;
        private MaterialSkin.Controls.MaterialLabel lblProduct;
        private MaterialSkin.Controls.MaterialLabel lblCurrentSuppliers;
        private System.Windows.Forms.ListBox lbCurrentSuppliers;
        private MaterialSkin.Controls.MaterialRaisedButton btnNewSupplier;
        private MaterialSkin.Controls.MaterialRaisedButton btnNewProduct;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditProductSupplier;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditSupplier;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditProduct;
    }
}