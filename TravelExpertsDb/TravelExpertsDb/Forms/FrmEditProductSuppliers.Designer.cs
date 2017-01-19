namespace TravelExpertsDb.Forms
{
    partial class FrmEditProductSuppliers
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
            this.lblProducts = new MaterialSkin.Controls.MaterialLabel();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbCurrentSuppliers = new System.Windows.Forms.ListBox();
            this.lbAllSuppliers = new System.Windows.Forms.ListBox();
            this.lblProductSuppliers = new MaterialSkin.Controls.MaterialLabel();
            this.lblAllSuppliers = new MaterialSkin.Controls.MaterialLabel();
            this.btnRemove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbPackages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Depth = 0;
            this.lblProducts.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProducts.Location = new System.Drawing.Point(12, 89);
            this.lblProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(73, 19);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Products:";
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(12, 111);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(185, 160);
            this.lbProducts.TabIndex = 1;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // lbCurrentSuppliers
            // 
            this.lbCurrentSuppliers.FormattingEnabled = true;
            this.lbCurrentSuppliers.Location = new System.Drawing.Point(241, 111);
            this.lbCurrentSuppliers.Name = "lbCurrentSuppliers";
            this.lbCurrentSuppliers.Size = new System.Drawing.Size(211, 160);
            this.lbCurrentSuppliers.TabIndex = 2;
            this.lbCurrentSuppliers.SelectedValueChanged += new System.EventHandler(this.lbCurrentSuppliers_SelectedValueChanged);
            // 
            // lbAllSuppliers
            // 
            this.lbAllSuppliers.FormattingEnabled = true;
            this.lbAllSuppliers.Location = new System.Drawing.Point(576, 111);
            this.lbAllSuppliers.Name = "lbAllSuppliers";
            this.lbAllSuppliers.Size = new System.Drawing.Size(194, 160);
            this.lbAllSuppliers.TabIndex = 3;
            // 
            // lblProductSuppliers
            // 
            this.lblProductSuppliers.AutoSize = true;
            this.lblProductSuppliers.Depth = 0;
            this.lblProductSuppliers.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProductSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductSuppliers.Location = new System.Drawing.Point(237, 89);
            this.lblProductSuppliers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductSuppliers.Name = "lblProductSuppliers";
            this.lblProductSuppliers.Size = new System.Drawing.Size(155, 19);
            this.lblProductSuppliers.TabIndex = 4;
            this.lblProductSuppliers.Text = "Current Suppliers for: ";
            // 
            // lblAllSuppliers
            // 
            this.lblAllSuppliers.AutoSize = true;
            this.lblAllSuppliers.Depth = 0;
            this.lblAllSuppliers.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAllSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAllSuppliers.Location = new System.Drawing.Point(572, 89);
            this.lblAllSuppliers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAllSuppliers.Name = "lblAllSuppliers";
            this.lblAllSuppliers.Size = new System.Drawing.Size(97, 19);
            this.lblAllSuppliers.TabIndex = 5;
            this.lblAllSuppliers.Text = "All Suppliers:";
            // 
            // btnRemove
            // 
            this.btnRemove.Depth = 0;
            this.btnRemove.Location = new System.Drawing.Point(478, 136);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Primary = true;
            this.btnRemove.Size = new System.Drawing.Size(67, 43);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(478, 210);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(67, 43);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(641, 325);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(129, 26);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(237, 287);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(215, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Packages For Current Supplier:";
            // 
            // lbPackages
            // 
            this.lbPackages.FormattingEnabled = true;
            this.lbPackages.Location = new System.Drawing.Point(241, 308);
            this.lbPackages.Name = "lbPackages";
            this.lbPackages.Size = new System.Drawing.Size(210, 43);
            this.lbPackages.TabIndex = 11;
            // 
            // FrmEditProductSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 367);
            this.Controls.Add(this.lbPackages);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblAllSuppliers);
            this.Controls.Add(this.lblProductSuppliers);
            this.Controls.Add(this.lbAllSuppliers);
            this.Controls.Add(this.lbCurrentSuppliers);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.lblProducts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditProductSuppliers";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product\'s Suppliers";
            this.Load += new System.EventHandler(this.FrmEditProductSuppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblProducts;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbCurrentSuppliers;
        private System.Windows.Forms.ListBox lbAllSuppliers;
        private MaterialSkin.Controls.MaterialLabel lblProductSuppliers;
        private MaterialSkin.Controls.MaterialLabel lblAllSuppliers;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemove;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListBox lbPackages;
    }
}