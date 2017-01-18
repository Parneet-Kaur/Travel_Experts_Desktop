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
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Depth = 0;
            this.btnOk.Location = new System.Drawing.Point(165, 167);
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
            this.btnCancel.Location = new System.Drawing.Point(285, 167);
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
            this.lblNewProduct.Location = new System.Drawing.Point(21, 108);
            this.lblNewProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewProduct.Name = "lblNewProduct";
            this.lblNewProduct.Size = new System.Drawing.Size(138, 19);
            this.lblNewProduct.TabIndex = 3;
            this.lblNewProduct.Text = "Enter New Product:";
            // 
            // txtNewProduct
            // 
            this.txtNewProduct.Depth = 0;
            this.txtNewProduct.Hint = "";
            this.txtNewProduct.Location = new System.Drawing.Point(179, 108);
            this.txtNewProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewProduct.Name = "txtNewProduct";
            this.txtNewProduct.PasswordChar = '\0';
            this.txtNewProduct.SelectedText = "";
            this.txtNewProduct.SelectionLength = 0;
            this.txtNewProduct.SelectionStart = 0;
            this.txtNewProduct.Size = new System.Drawing.Size(175, 23);
            this.txtNewProduct.TabIndex = 4;
            this.txtNewProduct.UseSystemPasswordChar = false;
            // 
            // FrmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 219);
            this.Controls.Add(this.txtNewProduct);
            this.Controls.Add(this.lblNewProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewProduct";
            this.Sizable = false;
            this.Text = "New Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnOk;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel lblNewProduct;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewProduct;
    }
}