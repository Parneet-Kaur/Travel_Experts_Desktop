namespace TravelExpertsDb.Forms
{
    partial class FrmLandingPage
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
            this.BtnPackages = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProductSuppliers = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPackages
            // 
            this.BtnPackages.Depth = 0;
            this.BtnPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPackages.Location = new System.Drawing.Point(27, 147);
            this.BtnPackages.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPackages.Name = "BtnPackages";
            this.BtnPackages.Primary = true;
            this.BtnPackages.Size = new System.Drawing.Size(173, 75);
            this.BtnPackages.TabIndex = 0;
            this.BtnPackages.Text = "Packages";
            this.BtnPackages.UseVisualStyleBackColor = true;
            this.BtnPackages.Click += new System.EventHandler(this.BtnPackages_Click);
            // 
            // btnProductSuppliers
            // 
            this.btnProductSuppliers.Depth = 0;
            this.btnProductSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSuppliers.Location = new System.Drawing.Point(233, 147);
            this.btnProductSuppliers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductSuppliers.Name = "btnProductSuppliers";
            this.btnProductSuppliers.Primary = true;
            this.btnProductSuppliers.Size = new System.Drawing.Size(173, 75);
            this.btnProductSuppliers.TabIndex = 1;
            this.btnProductSuppliers.Text = "Products/Suppliers";
            this.btnProductSuppliers.UseVisualStyleBackColor = true;
            this.btnProductSuppliers.Click += new System.EventHandler(this.btnProductSuppliers_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.White;
            this.lblLogo.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLogo.Location = new System.Drawing.Point(89, 84);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(275, 45);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "TRAVEL EXPERTS";
            // 
            // FrmLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 260);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btnProductSuppliers);
            this.Controls.Add(this.BtnPackages);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLandingPage";
            this.Text = "Welcome Back!";
            this.Load += new System.EventHandler(this.FrmLandingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnPackages;
        private MaterialSkin.Controls.MaterialRaisedButton btnProductSuppliers;
        private System.Windows.Forms.Label lblLogo;
    }
}