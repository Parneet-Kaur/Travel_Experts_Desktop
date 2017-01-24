namespace TravelExpertsDb
{
    partial class AddPackage
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
            this.lblPackageName = new MaterialSkin.Controls.MaterialLabel();
            this.lblStartDate = new MaterialSkin.Controls.MaterialLabel();
            this.lblEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.lblPackageDescription = new MaterialSkin.Controls.MaterialLabel();
            this.lblPkgBasePrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblAgencyCommision = new MaterialSkin.Controls.MaterialLabel();
            this.txtPackageName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.rtbPkgDesc = new System.Windows.Forms.RichTextBox();
            this.txtPkgBasePrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAgencyCommision = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddPackage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblPackageDetails = new MaterialSkin.Controls.MaterialLabel();
            this.lblProduct = new MaterialSkin.Controls.MaterialLabel();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.lbSuppliers = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lvSelectProductSupplier = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductSupplierId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Depth = 0;
            this.lblPackageName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPackageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPackageName.Location = new System.Drawing.Point(42, 111);
            this.lblPackageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(110, 19);
            this.lblPackageName.TabIndex = 0;
            this.lblPackageName.Text = "Package Name";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Depth = 0;
            this.lblStartDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStartDate.Location = new System.Drawing.Point(46, 156);
            this.lblStartDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 19);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Depth = 0;
            this.lblEndDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEndDate.Location = new System.Drawing.Point(46, 211);
            this.lblEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 19);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "End Date";
            // 
            // lblPackageDescription
            // 
            this.lblPackageDescription.AutoSize = true;
            this.lblPackageDescription.Depth = 0;
            this.lblPackageDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPackageDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPackageDescription.Location = new System.Drawing.Point(46, 267);
            this.lblPackageDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPackageDescription.Name = "lblPackageDescription";
            this.lblPackageDescription.Size = new System.Drawing.Size(86, 19);
            this.lblPackageDescription.TabIndex = 3;
            this.lblPackageDescription.Text = "Description";
            // 
            // lblPkgBasePrice
            // 
            this.lblPkgBasePrice.AutoSize = true;
            this.lblPkgBasePrice.Depth = 0;
            this.lblPkgBasePrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPkgBasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPkgBasePrice.Location = new System.Drawing.Point(46, 364);
            this.lblPkgBasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPkgBasePrice.Name = "lblPkgBasePrice";
            this.lblPkgBasePrice.Size = new System.Drawing.Size(80, 19);
            this.lblPkgBasePrice.TabIndex = 4;
            this.lblPkgBasePrice.Text = "Base Price";
            // 
            // lblAgencyCommision
            // 
            this.lblAgencyCommision.AutoSize = true;
            this.lblAgencyCommision.Depth = 0;
            this.lblAgencyCommision.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAgencyCommision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAgencyCommision.Location = new System.Drawing.Point(42, 408);
            this.lblAgencyCommision.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAgencyCommision.Name = "lblAgencyCommision";
            this.lblAgencyCommision.Size = new System.Drawing.Size(140, 19);
            this.lblAgencyCommision.TabIndex = 5;
            this.lblAgencyCommision.Text = "Agency Commision";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Depth = 0;
            this.txtPackageName.Hint = "";
            this.txtPackageName.Location = new System.Drawing.Point(215, 106);
            this.txtPackageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.PasswordChar = '\0';
            this.txtPackageName.SelectedText = "";
            this.txtPackageName.SelectionLength = 0;
            this.txtPackageName.SelectionStart = 0;
            this.txtPackageName.Size = new System.Drawing.Size(200, 23);
            this.txtPackageName.TabIndex = 6;
            this.txtPackageName.UseSystemPasswordChar = false;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(215, 154);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 7;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(215, 211);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 8;
            // 
            // rtbPkgDesc
            // 
            this.rtbPkgDesc.Location = new System.Drawing.Point(215, 267);
            this.rtbPkgDesc.Name = "rtbPkgDesc";
            this.rtbPkgDesc.Size = new System.Drawing.Size(200, 75);
            this.rtbPkgDesc.TabIndex = 11;
            this.rtbPkgDesc.Text = "";
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Depth = 0;
            this.txtPkgBasePrice.Hint = "";
            this.txtPkgBasePrice.Location = new System.Drawing.Point(215, 364);
            this.txtPkgBasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.PasswordChar = '\0';
            this.txtPkgBasePrice.SelectedText = "";
            this.txtPkgBasePrice.SelectionLength = 0;
            this.txtPkgBasePrice.SelectionStart = 0;
            this.txtPkgBasePrice.Size = new System.Drawing.Size(200, 23);
            this.txtPkgBasePrice.TabIndex = 12;
            this.txtPkgBasePrice.UseSystemPasswordChar = false;
            // 
            // txtAgencyCommision
            // 
            this.txtAgencyCommision.Depth = 0;
            this.txtAgencyCommision.Hint = "";
            this.txtAgencyCommision.Location = new System.Drawing.Point(215, 408);
            this.txtAgencyCommision.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAgencyCommision.Name = "txtAgencyCommision";
            this.txtAgencyCommision.PasswordChar = '\0';
            this.txtAgencyCommision.SelectedText = "";
            this.txtAgencyCommision.SelectionLength = 0;
            this.txtAgencyCommision.SelectionStart = 0;
            this.txtAgencyCommision.Size = new System.Drawing.Size(200, 23);
            this.txtAgencyCommision.TabIndex = 13;
            this.txtAgencyCommision.UseSystemPasswordChar = false;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Depth = 0;
            this.btnAddPackage.Location = new System.Drawing.Point(40, 485);
            this.btnAddPackage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Primary = true;
            this.btnAddPackage.Size = new System.Drawing.Size(75, 23);
            this.btnAddPackage.TabIndex = 14;
            this.btnAddPackage.Text = "ADD";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // lblPackageDetails
            // 
            this.lblPackageDetails.AutoSize = true;
            this.lblPackageDetails.Depth = 0;
            this.lblPackageDetails.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPackageDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPackageDetails.Location = new System.Drawing.Point(471, 71);
            this.lblPackageDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPackageDetails.Name = "lblPackageDetails";
            this.lblPackageDetails.Size = new System.Drawing.Size(190, 19);
            this.lblPackageDetails.TabIndex = 15;
            this.lblPackageDetails.Text = "This package should have :";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Depth = 0;
            this.lblProduct.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProduct.Location = new System.Drawing.Point(471, 114);
            this.lblProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(69, 19);
            this.lblProduct.TabIndex = 16;
            this.lblProduct.Text = "Products";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(558, 112);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(121, 21);
            this.cbProducts.TabIndex = 17;
            // 
            // lbSuppliers
            // 
            this.lbSuppliers.FormattingEnabled = true;
            this.lbSuppliers.Location = new System.Drawing.Point(475, 172);
            this.lbSuppliers.Name = "lbSuppliers";
            this.lbSuppliers.Size = new System.Drawing.Size(169, 160);
            this.lbSuppliers.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(662, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(662, 238);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(39, 23);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lvSelectProductSupplier
            // 
            this.lvSelectProductSupplier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Supplier,
            this.ProductSupplierId});
            this.lvSelectProductSupplier.Location = new System.Drawing.Point(717, 172);
            this.lvSelectProductSupplier.Name = "lvSelectProductSupplier";
            this.lvSelectProductSupplier.Size = new System.Drawing.Size(183, 160);
            this.lvSelectProductSupplier.TabIndex = 21;
            this.lvSelectProductSupplier.UseCompatibleStateImageBehavior = false;
            this.lvSelectProductSupplier.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            // 
            // Supplier
            // 
            this.Supplier.Text = "Supplier";
            this.Supplier.Width = 116;
            // 
            // ProductSupplierId
            // 
            this.ProductSupplierId.Text = "ProductSupplierId";
            this.ProductSupplierId.Width = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(142, 485);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 535);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvSelectProductSupplier);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbSuppliers);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblPackageDetails);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.txtAgencyCommision);
            this.Controls.Add(this.txtPkgBasePrice);
            this.Controls.Add(this.rtbPkgDesc);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.lblAgencyCommision);
            this.Controls.Add(this.lblPkgBasePrice);
            this.Controls.Add(this.lblPackageDescription);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblPackageName);
            this.Name = "AddPackage";
            this.Text = "Add another package for your customers";
            this.Load += new System.EventHandler(this.AddPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblPackageName;
        private MaterialSkin.Controls.MaterialLabel lblStartDate;
        private MaterialSkin.Controls.MaterialLabel lblEndDate;
        private MaterialSkin.Controls.MaterialLabel lblPackageDescription;
        private MaterialSkin.Controls.MaterialLabel lblPkgBasePrice;
        private MaterialSkin.Controls.MaterialLabel lblAgencyCommision;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPackageName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.RichTextBox rtbPkgDesc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPkgBasePrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAgencyCommision;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddPackage;
        private MaterialSkin.Controls.MaterialLabel lblPackageDetails;
        private MaterialSkin.Controls.MaterialLabel lblProduct;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.ListBox lbSuppliers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView lvSelectProductSupplier;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Supplier;
        private System.Windows.Forms.ColumnHeader ProductSupplierId;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
    }
}