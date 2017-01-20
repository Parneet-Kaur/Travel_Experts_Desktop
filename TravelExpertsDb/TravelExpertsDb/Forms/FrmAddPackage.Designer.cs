namespace TravelExpertsDb.Forms
{
    partial class FrmAddPackage
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
            this.lblPackageEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.lblBasePrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblCommission = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.BtnAccept = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbSuppliers = new System.Windows.Forms.ListBox();
            this.lvPackageProductSuppliers = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductSupplierId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPackageName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBasePrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCommission = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRemove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Depth = 0;
            this.lblPackageName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPackageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPackageName.Location = new System.Drawing.Point(46, 76);
            this.lblPackageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(114, 19);
            this.lblPackageName.TabIndex = 0;
            this.lblPackageName.Text = "Package Name:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Depth = 0;
            this.lblStartDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStartDate.Location = new System.Drawing.Point(80, 116);
            this.lblStartDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(80, 19);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblPackageEndDate
            // 
            this.lblPackageEndDate.AutoSize = true;
            this.lblPackageEndDate.Depth = 0;
            this.lblPackageEndDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPackageEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPackageEndDate.Location = new System.Drawing.Point(87, 149);
            this.lblPackageEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPackageEndDate.Name = "lblPackageEndDate";
            this.lblPackageEndDate.Size = new System.Drawing.Size(73, 19);
            this.lblPackageEndDate.TabIndex = 2;
            this.lblPackageEndDate.Text = "End Date:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.Location = new System.Drawing.Point(70, 184);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 19);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Depth = 0;
            this.lblBasePrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBasePrice.Location = new System.Drawing.Point(76, 296);
            this.lblBasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(84, 19);
            this.lblBasePrice.TabIndex = 4;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Depth = 0;
            this.lblCommission.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCommission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCommission.Location = new System.Drawing.Point(46, 339);
            this.lblCommission.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(99, 19);
            this.lblCommission.TabIndex = 5;
            this.lblCommission.Text = "Commission:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(183, 185);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(156, 98);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "";
            // 
            // BtnAccept
            // 
            this.BtnAccept.Depth = 0;
            this.BtnAccept.Location = new System.Drawing.Point(590, 339);
            this.BtnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Primary = true;
            this.BtnAccept.Size = new System.Drawing.Size(101, 32);
            this.BtnAccept.TabIndex = 7;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Location = new System.Drawing.Point(737, 339);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = true;
            this.BtnCancel.Size = new System.Drawing.Size(101, 32);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lbSuppliers
            // 
            this.lbSuppliers.FormattingEnabled = true;
            this.lbSuppliers.Location = new System.Drawing.Point(414, 168);
            this.lbSuppliers.Name = "lbSuppliers";
            this.lbSuppliers.Size = new System.Drawing.Size(167, 147);
            this.lbSuppliers.TabIndex = 9;
            // 
            // lvPackageProductSuppliers
            // 
            this.lvPackageProductSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Supplier,
            this.ProductSupplierId});
            this.lvPackageProductSuppliers.Location = new System.Drawing.Point(687, 168);
            this.lvPackageProductSuppliers.Name = "lvPackageProductSuppliers";
            this.lvPackageProductSuppliers.Size = new System.Drawing.Size(205, 147);
            this.lvPackageProductSuppliers.TabIndex = 10;
            this.lvPackageProductSuppliers.UseCompatibleStateImageBehavior = false;
            this.lvPackageProductSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 74;
            // 
            // Supplier
            // 
            this.Supplier.Text = "Supplier";
            this.Supplier.Width = 127;
            // 
            // ProductSupplierId
            // 
            this.ProductSupplierId.Width = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(410, 146);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Suppliers:";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Depth = 0;
            this.txtPackageName.Hint = "";
            this.txtPackageName.Location = new System.Drawing.Point(183, 76);
            this.txtPackageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.PasswordChar = '\0';
            this.txtPackageName.SelectedText = "";
            this.txtPackageName.SelectionLength = 0;
            this.txtPackageName.SelectionStart = 0;
            this.txtPackageName.Size = new System.Drawing.Size(156, 23);
            this.txtPackageName.TabIndex = 12;
            this.txtPackageName.UseSystemPasswordChar = false;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Depth = 0;
            this.txtBasePrice.Hint = "";
            this.txtBasePrice.Location = new System.Drawing.Point(183, 296);
            this.txtBasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.PasswordChar = '\0';
            this.txtBasePrice.SelectedText = "";
            this.txtBasePrice.SelectionLength = 0;
            this.txtBasePrice.SelectionStart = 0;
            this.txtBasePrice.Size = new System.Drawing.Size(156, 23);
            this.txtBasePrice.TabIndex = 15;
            this.txtBasePrice.UseSystemPasswordChar = false;
            // 
            // txtCommission
            // 
            this.txtCommission.Depth = 0;
            this.txtCommission.Hint = "";
            this.txtCommission.Location = new System.Drawing.Point(183, 339);
            this.txtCommission.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.PasswordChar = '\0';
            this.txtCommission.SelectedText = "";
            this.txtCommission.SelectionLength = 0;
            this.txtCommission.SelectionStart = 0;
            this.txtCommission.Size = new System.Drawing.Size(156, 23);
            this.txtCommission.TabIndex = 16;
            this.txtCommission.UseSystemPasswordChar = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(608, 174);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(46, 41);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Depth = 0;
            this.btnRemove.Location = new System.Drawing.Point(608, 257);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Primary = true;
            this.btnRemove.Size = new System.Drawing.Size(46, 41);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(687, 146);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(205, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Package\'s Product/Suppliers:";
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(414, 98);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(121, 21);
            this.cboProduct.TabIndex = 20;
            this.cboProduct.SelectedValueChanged += new System.EventHandler(this.cboProduct_SelectedValueChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(410, 76);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 19);
            this.materialLabel3.TabIndex = 21;
            this.materialLabel3.Text = "Products:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(183, 114);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(156, 20);
            this.dtpStartDate.TabIndex = 22;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(183, 149);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(156, 20);
            this.dtpEndDate.TabIndex = 23;
            // 
            // FrmAddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 393);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lvPackageProductSuppliers);
            this.Controls.Add(this.lbSuppliers);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPackageEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblPackageName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a New Package";
            this.Load += new System.EventHandler(this.FrmAddPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblPackageName;
        private MaterialSkin.Controls.MaterialLabel lblStartDate;
        private MaterialSkin.Controls.MaterialLabel lblPackageEndDate;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private MaterialSkin.Controls.MaterialLabel lblBasePrice;
        private MaterialSkin.Controls.MaterialLabel lblCommission;
        private System.Windows.Forms.RichTextBox txtDescription;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAccept;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCancel;
        private System.Windows.Forms.ListBox lbSuppliers;
        private System.Windows.Forms.ListView lvPackageProductSuppliers;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPackageName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBasePrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCommission;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemove;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox cboProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Supplier;
        private System.Windows.Forms.ColumnHeader ProductSupplierId;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}