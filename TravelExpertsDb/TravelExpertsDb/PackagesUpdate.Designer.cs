namespace TravelExpertsDb
{
    partial class PackagesUpdate
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
            this.cbPkgName = new System.Windows.Forms.ComboBox();
            this.lblPackageId = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // cbPkgName
            // 
            this.cbPkgName.FormattingEnabled = true;
            this.cbPkgName.Location = new System.Drawing.Point(184, 103);
            this.cbPkgName.Name = "cbPkgName";
            this.cbPkgName.Size = new System.Drawing.Size(121, 21);
            this.cbPkgName.TabIndex = 0;
            // 
            // lblPackageId
            // 
            this.lblPackageId.AutoSize = true;
            this.lblPackageId.Depth = 0;
            this.lblPackageId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPackageId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPackageId.Location = new System.Drawing.Point(32, 103);
            this.lblPackageId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPackageId.Name = "lblPackageId";
            this.lblPackageId.Size = new System.Drawing.Size(84, 19);
            this.lblPackageId.TabIndex = 1;
            this.lblPackageId.Text = "Package ID";
            // 
            // PackagesUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 365);
            this.Controls.Add(this.lblPackageId);
            this.Controls.Add(this.cbPkgName);
            this.Name = "PackagesUpdate";
            this.Text = "Choose a package to update.";
            this.Load += new System.EventHandler(this.PackagesUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPkgName;
        private MaterialSkin.Controls.MaterialLabel lblPackageId;
    }
}