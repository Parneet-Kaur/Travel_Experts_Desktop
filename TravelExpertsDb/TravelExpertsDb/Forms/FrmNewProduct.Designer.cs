namespace TravelExpertsDb.Forms
{
    partial class FrmNewProduct
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
            this.btnOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblNewProduct = new MaterialSkin.Controls.MaterialLabel();
            this.txtNewProduct = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbAllSuppliers = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lvCurrentSuppliers = new System.Windows.Forms.ListView();
            this.SupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Depth = 0;
            this.btnOk.Location = new System.Drawing.Point(25, 248);
            this.btnOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.Primary = true;
            this.btnOk.Size = new System.Drawing.Size(99, 28);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(155, 248);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(99, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNewProduct
            // 
            this.lblNewProduct.AutoSize = true;
            this.lblNewProduct.Depth = 0;
            this.lblNewProduct.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNewProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNewProduct.Location = new System.Drawing.Point(21, 91);
            this.lblNewProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewProduct.Name = "lblNewProduct";
            this.lblNewProduct.Size = new System.Drawing.Size(152, 19);
            this.lblNewProduct.TabIndex = 3;
            this.lblNewProduct.Text = "Enter A New Product:";
            // 
            // txtNewProduct
            // 
            this.txtNewProduct.Depth = 0;
            this.txtNewProduct.Hint = "";
            this.txtNewProduct.Location = new System.Drawing.Point(25, 125);
            this.txtNewProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewProduct.Name = "txtNewProduct";
            this.txtNewProduct.PasswordChar = '\0';
            this.txtNewProduct.SelectedText = "";
            this.txtNewProduct.SelectionLength = 0;
            this.txtNewProduct.SelectionStart = 0;
            this.txtNewProduct.Size = new System.Drawing.Size(229, 23);
            this.txtNewProduct.TabIndex = 4;
            this.txtNewProduct.Tag = "Product Name";
            this.txtNewProduct.UseSystemPasswordChar = false;
            // 
            // lbAllSuppliers
            // 
            this.lbAllSuppliers.FormattingEnabled = true;
            this.lbAllSuppliers.Location = new System.Drawing.Point(303, 116);
            this.lbAllSuppliers.Name = "lbAllSuppliers";
            this.lbAllSuppliers.Size = new System.Drawing.Size(192, 160);
            this.lbAllSuppliers.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(518, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(518, 217);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(51, 36);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(299, 91);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "All Suppliers:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(589, 94);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(128, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Current Suppliers:";
            // 
            // lvCurrentSuppliers
            // 
            this.lvCurrentSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SupName,
            this.SupID});
            this.lvCurrentSuppliers.Location = new System.Drawing.Point(593, 116);
            this.lvCurrentSuppliers.Name = "lvCurrentSuppliers";
            this.lvCurrentSuppliers.Size = new System.Drawing.Size(181, 160);
            this.lvCurrentSuppliers.TabIndex = 11;
            this.lvCurrentSuppliers.UseCompatibleStateImageBehavior = false;
            this.lvCurrentSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // SupName
            // 
            this.SupName.Text = "Supplier Name";
            this.SupName.Width = 173;
            // 
            // SupID
            // 
            this.SupID.Width = 0;
            // 
            // FrmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 298);
            this.Controls.Add(this.lvCurrentSuppliers);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbAllSuppliers);
            this.Controls.Add(this.txtNewProduct);
            this.Controls.Add(this.lblNewProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewProduct";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Product Name";
            this.Text = "New Product";
            this.Load += new System.EventHandler(this.FrmNewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnOk;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel lblNewProduct;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewProduct;
        private System.Windows.Forms.ListBox lbAllSuppliers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ListView lvCurrentSuppliers;
        private System.Windows.Forms.ColumnHeader SupID;
        private System.Windows.Forms.ColumnHeader SupName;
    }
}