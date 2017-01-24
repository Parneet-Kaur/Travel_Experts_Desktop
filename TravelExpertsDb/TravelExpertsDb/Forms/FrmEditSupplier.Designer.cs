namespace TravelExpertsDb.Forms
{
    partial class FrmEditSupplier
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
            this.lblEditSupplier = new MaterialSkin.Controls.MaterialLabel();
            this.lbSuppliers = new System.Windows.Forms.ListBox();
            this.lblCurrentSupplierName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNewSuppliersName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCurrentSuppliersID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNewSupplier = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // lblEditSupplier
            // 
            this.lblEditSupplier.AutoSize = true;
            this.lblEditSupplier.Depth = 0;
            this.lblEditSupplier.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEditSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEditSupplier.Location = new System.Drawing.Point(12, 82);
            this.lblEditSupplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditSupplier.Name = "lblEditSupplier";
            this.lblEditSupplier.Size = new System.Drawing.Size(171, 19);
            this.lblEditSupplier.TabIndex = 0;
            this.lblEditSupplier.Text = "Choose Supplier to Edit:";
            // 
            // lbSuppliers
            // 
            this.lbSuppliers.FormattingEnabled = true;
            this.lbSuppliers.Location = new System.Drawing.Point(16, 104);
            this.lbSuppliers.Name = "lbSuppliers";
            this.lbSuppliers.Size = new System.Drawing.Size(202, 121);
            this.lbSuppliers.TabIndex = 1;
            this.lbSuppliers.SelectedValueChanged += new System.EventHandler(this.lbSuppliers_SelectedValueChanged);
            // 
            // lblCurrentSupplierName
            // 
            this.lblCurrentSupplierName.Depth = 0;
            this.lblCurrentSupplierName.Hint = "";
            this.lblCurrentSupplierName.Location = new System.Drawing.Point(273, 78);
            this.lblCurrentSupplierName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentSupplierName.Name = "lblCurrentSupplierName";
            this.lblCurrentSupplierName.PasswordChar = '\0';
            this.lblCurrentSupplierName.SelectedText = "";
            this.lblCurrentSupplierName.SelectionLength = 0;
            this.lblCurrentSupplierName.SelectionStart = 0;
            this.lblCurrentSupplierName.Size = new System.Drawing.Size(220, 23);
            this.lblCurrentSupplierName.TabIndex = 2;
            this.lblCurrentSupplierName.Text = "Current Supplier\'s Name:";
            this.lblCurrentSupplierName.UseSystemPasswordChar = false;
            // 
            // lblNewSuppliersName
            // 
            this.lblNewSuppliersName.Depth = 0;
            this.lblNewSuppliersName.Hint = "";
            this.lblNewSuppliersName.Location = new System.Drawing.Point(273, 163);
            this.lblNewSuppliersName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewSuppliersName.Name = "lblNewSuppliersName";
            this.lblNewSuppliersName.PasswordChar = '\0';
            this.lblNewSuppliersName.SelectedText = "";
            this.lblNewSuppliersName.SelectionLength = 0;
            this.lblNewSuppliersName.SelectionStart = 0;
            this.lblNewSuppliersName.Size = new System.Drawing.Size(220, 23);
            this.lblNewSuppliersName.TabIndex = 3;
            this.lblNewSuppliersName.Text = "Change Supplier\'s Name To:";
            this.lblNewSuppliersName.UseSystemPasswordChar = false;
            // 
            // txtCurrentSuppliersID
            // 
            this.txtCurrentSuppliersID.Depth = 0;
            this.txtCurrentSuppliersID.Enabled = false;
            this.txtCurrentSuppliersID.Hint = "";
            this.txtCurrentSuppliersID.Location = new System.Drawing.Point(273, 116);
            this.txtCurrentSuppliersID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCurrentSuppliersID.Name = "txtCurrentSuppliersID";
            this.txtCurrentSuppliersID.PasswordChar = '\0';
            this.txtCurrentSuppliersID.SelectedText = "";
            this.txtCurrentSuppliersID.SelectionLength = 0;
            this.txtCurrentSuppliersID.SelectionStart = 0;
            this.txtCurrentSuppliersID.Size = new System.Drawing.Size(220, 23);
            this.txtCurrentSuppliersID.TabIndex = 4;
            this.txtCurrentSuppliersID.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(256, 248);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(114, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(388, 248);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(114, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNewSupplier
            // 
            this.txtNewSupplier.Depth = 0;
            this.txtNewSupplier.Hint = "";
            this.txtNewSupplier.Location = new System.Drawing.Point(273, 201);
            this.txtNewSupplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewSupplier.Name = "txtNewSupplier";
            this.txtNewSupplier.PasswordChar = '\0';
            this.txtNewSupplier.SelectedText = "";
            this.txtNewSupplier.SelectionLength = 0;
            this.txtNewSupplier.SelectionStart = 0;
            this.txtNewSupplier.Size = new System.Drawing.Size(220, 23);
            this.txtNewSupplier.TabIndex = 7;
            this.txtNewSupplier.Tag = "Supplier Name";
            this.txtNewSupplier.UseSystemPasswordChar = false;
            // 
            // FrmEditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 305);
            this.Controls.Add(this.txtNewSupplier);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCurrentSuppliersID);
            this.Controls.Add(this.lblNewSuppliersName);
            this.Controls.Add(this.lblCurrentSupplierName);
            this.Controls.Add(this.lbSuppliers);
            this.Controls.Add(this.lblEditSupplier);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditSupplier";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Supplier";
            this.Load += new System.EventHandler(this.FrmEditSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblEditSupplier;
        private System.Windows.Forms.ListBox lbSuppliers;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblCurrentSupplierName;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblNewSuppliersName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCurrentSuppliersID;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewSupplier;
    }
}