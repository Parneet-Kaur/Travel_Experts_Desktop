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
            this.lbSuppliers = new System.Windows.Forms.ListBox();
            this.txtCurrentSuppliersID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNewSupplier = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Change Supplier\'s Name To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current Supplier\'s Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choose Supplier to Edit:";
            // 
            // FrmEditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 305);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewSupplier);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCurrentSuppliersID);
            this.Controls.Add(this.lbSuppliers);
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
        private System.Windows.Forms.ListBox lbSuppliers;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCurrentSuppliersID;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}