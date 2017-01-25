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
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnPackages = new System.Windows.Forms.Button();
            this.btnProductSuppliers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.White;
            this.lblLogo.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.lblLogo.Location = new System.Drawing.Point(246, 79);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(357, 59);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "TRAVEL EXPERTS";
            // 
            // btnPackages
            // 
            this.btnPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPackages.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPackages.Location = new System.Drawing.Point(110, 173);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(254, 114);
            this.btnPackages.TabIndex = 4;
            this.btnPackages.Text = "PACKAGES";
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // btnProductSuppliers
            // 
            this.btnProductSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnProductSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductSuppliers.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSuppliers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductSuppliers.Location = new System.Drawing.Point(477, 173);
            this.btnProductSuppliers.Name = "btnProductSuppliers";
            this.btnProductSuppliers.Size = new System.Drawing.Size(254, 114);
            this.btnProductSuppliers.TabIndex = 5;
            this.btnProductSuppliers.Text = "PRODUCT/SUPPLIERS";
            this.btnProductSuppliers.UseVisualStyleBackColor = false;
            this.btnProductSuppliers.Click += new System.EventHandler(this.btnProductSuppliers_Click_1);
            // 
            // FrmLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 368);
            this.Controls.Add(this.btnProductSuppliers);
            this.Controls.Add(this.btnPackages);
            this.Controls.Add(this.lblLogo);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Back!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLandingPage_FormClosing);
            this.Load += new System.EventHandler(this.FrmLandingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.Button btnProductSuppliers;
    }
}