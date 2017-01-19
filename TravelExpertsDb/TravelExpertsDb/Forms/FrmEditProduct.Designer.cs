namespace TravelExpertsDb.Forms
{
    partial class FrmEditProduct
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
            this.txtNewProduct = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCurrentProductName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNewProductName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCurrentProductName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbProduct = new System.Windows.Forms.ListBox();
            this.lblEditProduct = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtNewProduct
            // 
            this.txtNewProduct.Depth = 0;
            this.txtNewProduct.Hint = "";
            this.txtNewProduct.Location = new System.Drawing.Point(269, 202);
            this.txtNewProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewProduct.Name = "txtNewProduct";
            this.txtNewProduct.PasswordChar = '\0';
            this.txtNewProduct.SelectedText = "";
            this.txtNewProduct.SelectionLength = 0;
            this.txtNewProduct.SelectionStart = 0;
            this.txtNewProduct.Size = new System.Drawing.Size(220, 23);
            this.txtNewProduct.TabIndex = 15;
            this.txtNewProduct.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(384, 249);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(114, 30);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(252, 249);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(114, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCurrentProductName
            // 
            this.txtCurrentProductName.Depth = 0;
            this.txtCurrentProductName.Enabled = false;
            this.txtCurrentProductName.Hint = "";
            this.txtCurrentProductName.Location = new System.Drawing.Point(269, 117);
            this.txtCurrentProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCurrentProductName.Name = "txtCurrentProductName";
            this.txtCurrentProductName.PasswordChar = '\0';
            this.txtCurrentProductName.SelectedText = "";
            this.txtCurrentProductName.SelectionLength = 0;
            this.txtCurrentProductName.SelectionStart = 0;
            this.txtCurrentProductName.Size = new System.Drawing.Size(220, 23);
            this.txtCurrentProductName.TabIndex = 12;
            this.txtCurrentProductName.UseSystemPasswordChar = false;
            // 
            // lblNewProductName
            // 
            this.lblNewProductName.Depth = 0;
            this.lblNewProductName.Hint = "";
            this.lblNewProductName.Location = new System.Drawing.Point(269, 164);
            this.lblNewProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewProductName.Name = "lblNewProductName";
            this.lblNewProductName.PasswordChar = '\0';
            this.lblNewProductName.SelectedText = "";
            this.lblNewProductName.SelectionLength = 0;
            this.lblNewProductName.SelectionStart = 0;
            this.lblNewProductName.Size = new System.Drawing.Size(220, 23);
            this.lblNewProductName.TabIndex = 11;
            this.lblNewProductName.Text = "Change Product\'s Name To:";
            this.lblNewProductName.UseSystemPasswordChar = false;
            // 
            // lblCurrentProductName
            // 
            this.lblCurrentProductName.Depth = 0;
            this.lblCurrentProductName.Hint = "";
            this.lblCurrentProductName.Location = new System.Drawing.Point(269, 79);
            this.lblCurrentProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentProductName.Name = "lblCurrentProductName";
            this.lblCurrentProductName.PasswordChar = '\0';
            this.lblCurrentProductName.SelectedText = "";
            this.lblCurrentProductName.SelectionLength = 0;
            this.lblCurrentProductName.SelectionStart = 0;
            this.lblCurrentProductName.Size = new System.Drawing.Size(220, 23);
            this.lblCurrentProductName.TabIndex = 10;
            this.lblCurrentProductName.Text = "Current Product\'s Name:";
            this.lblCurrentProductName.UseSystemPasswordChar = false;
            // 
            // lbProduct
            // 
            this.lbProduct.FormattingEnabled = true;
            this.lbProduct.Location = new System.Drawing.Point(12, 105);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(202, 121);
            this.lbProduct.TabIndex = 9;
            this.lbProduct.SelectedValueChanged += new System.EventHandler(this.lbProduct_SelectedValueChanged);
            // 
            // lblEditProduct
            // 
            this.lblEditProduct.AutoSize = true;
            this.lblEditProduct.Depth = 0;
            this.lblEditProduct.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEditProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEditProduct.Location = new System.Drawing.Point(8, 83);
            this.lblEditProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditProduct.Name = "lblEditProduct";
            this.lblEditProduct.Size = new System.Drawing.Size(169, 19);
            this.lblEditProduct.TabIndex = 8;
            this.lblEditProduct.Text = "Choose Product to Edit:";
            // 
            // FrmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 307);
            this.Controls.Add(this.txtNewProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCurrentProductName);
            this.Controls.Add(this.lblNewProductName);
            this.Controls.Add(this.lblCurrentProductName);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.lblEditProduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditProduct";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.FrmEditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewProduct;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCurrentProductName;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblNewProductName;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblCurrentProductName;
        private System.Windows.Forms.ListBox lbProduct;
        private MaterialSkin.Controls.MaterialLabel lblEditProduct;
    }
}