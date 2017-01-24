namespace TravelExpertsDb
{
    partial class DefaultPackages
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
            this.btnAddPackage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdatePackage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtgPackages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Depth = 0;
            this.btnAddPackage.Location = new System.Drawing.Point(152, 243);
            this.btnAddPackage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Primary = true;
            this.btnAddPackage.Size = new System.Drawing.Size(138, 65);
            this.btnAddPackage.TabIndex = 0;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnUpdatePackage
            // 
            this.btnUpdatePackage.Depth = 0;
            this.btnUpdatePackage.Location = new System.Drawing.Point(367, 243);
            this.btnUpdatePackage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdatePackage.Name = "btnUpdatePackage";
            this.btnUpdatePackage.Primary = true;
            this.btnUpdatePackage.Size = new System.Drawing.Size(138, 65);
            this.btnUpdatePackage.TabIndex = 1;
            this.btnUpdatePackage.Text = "Update Package";
            this.btnUpdatePackage.UseVisualStyleBackColor = true;
            this.btnUpdatePackage.Click += new System.EventHandler(this.btnUpdatePackage_Click);
            // 
            // dtgPackages
            // 
            this.dtgPackages.AllowUserToAddRows = false;
            this.dtgPackages.AllowUserToDeleteRows = false;
            this.dtgPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPackages.Location = new System.Drawing.Point(28, 76);
            this.dtgPackages.Name = "dtgPackages";
            this.dtgPackages.ReadOnly = true;
            this.dtgPackages.RowHeadersVisible = false;
            this.dtgPackages.ShowCellErrors = false;
            this.dtgPackages.ShowCellToolTips = false;
            this.dtgPackages.ShowEditingIcon = false;
            this.dtgPackages.ShowRowErrors = false;
            this.dtgPackages.Size = new System.Drawing.Size(596, 150);
            this.dtgPackages.TabIndex = 2;
            // 
            // DefaultPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 331);
            this.Controls.Add(this.dtgPackages);
            this.Controls.Add(this.btnUpdatePackage);
            this.Controls.Add(this.btnAddPackage);
            this.Name = "DefaultPackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit your packages here. ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DefaultPackages_FormClosing);
            this.Load += new System.EventHandler(this.DefaultPackages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPackages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAddPackage;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdatePackage;
        private System.Windows.Forms.DataGridView dtgPackages;
    }
}