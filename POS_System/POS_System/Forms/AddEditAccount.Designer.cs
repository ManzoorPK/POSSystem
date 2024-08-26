namespace POS_System.Forms
{
    partial class AddEditAccount
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
            this.label12 = new System.Windows.Forms.Label();
            this.lblTitle = new Telerik.WinControls.UI.RadLabel();
            this.txtTitle = new Telerik.WinControls.UI.RadTextBox();
            this.radButtonCancel = new Telerik.WinControls.UI.RadButton();
            this.radButtonSave = new Telerik.WinControls.UI.RadButton();
            this.txtAddress = new Telerik.WinControls.UI.RadTextBox();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContact = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new Telerik.WinControls.UI.RadTextBox();
            this.rdCustomer = new Telerik.WinControls.UI.RadRadioButton();
            this.rdSupplier = new Telerik.WinControls.UI.RadRadioButton();
            this.rdOther = new Telerik.WinControls.UI.RadRadioButton();
            this.rdSalesman = new Telerik.WinControls.UI.RadRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSalesman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(692, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 19);
            this.label12.TabIndex = 75;
            this.label12.Text = "Account Title";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(301, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add new Account";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblTitle.ThemeName = "Office2010Blue";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtTitle.Location = new System.Drawing.Point(433, 49);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(253, 29);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.ThemeName = "Office2010Blue";
            // 
            // radButtonCancel
            // 
            this.radButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonCancel.BackColor = System.Drawing.Color.White;
            this.radButtonCancel.Location = new System.Drawing.Point(202, 188);
            this.radButtonCancel.Name = "radButtonCancel";
            this.radButtonCancel.Size = new System.Drawing.Size(94, 32);
            this.radButtonCancel.TabIndex = 10;
            this.radButtonCancel.Text = "Close";
            this.radButtonCancel.ThemeName = "Office2010Blue";
            this.radButtonCancel.Click += new System.EventHandler(this.radButtonCancel_Click);
            // 
            // radButtonSave
            // 
            this.radButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonSave.BackColor = System.Drawing.Color.White;
            this.radButtonSave.Location = new System.Drawing.Point(25, 188);
            this.radButtonSave.Name = "radButtonSave";
            this.radButtonSave.Size = new System.Drawing.Size(171, 32);
            this.radButtonSave.TabIndex = 9;
            this.radButtonSave.Text = "Save Changes";
            this.radButtonSave.ThemeName = "Office2010Blue";
            this.radButtonSave.Click += new System.EventHandler(this.radButtonSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtAddress.Location = new System.Drawing.Point(24, 122);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            // 
            // 
            // 
            this.txtAddress.RootElement.StretchVertically = true;
            this.txtAddress.Size = new System.Drawing.Size(662, 60);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.ThemeName = "Office2010Blue";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(692, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 80;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(692, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtEmail.Location = new System.Drawing.Point(433, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 29);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.ThemeName = "Office2010Blue";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(277, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 77;
            this.label1.Text = "Contact #";
            // 
            // txtContact
            // 
            this.txtContact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtContact.Location = new System.Drawing.Point(24, 87);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(253, 29);
            this.txtContact.TabIndex = 3;
            this.txtContact.ThemeName = "Office2010Blue";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lblTitle);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(797, 33);
            this.radGroupBox1.TabIndex = 72;
            this.radGroupBox1.ThemeName = "TelerikMetroTouch";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(277, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 82;
            this.label4.Text = "Account Code";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtCode.Location = new System.Drawing.Point(24, 49);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(253, 29);
            this.txtCode.TabIndex = 1;
            this.txtCode.ThemeName = "Office2010Blue";
            // 
            // rdCustomer
            // 
            this.rdCustomer.Location = new System.Drawing.Point(616, 188);
            this.rdCustomer.Name = "rdCustomer";
            this.rdCustomer.Size = new System.Drawing.Size(70, 18);
            this.rdCustomer.TabIndex = 5;
            this.rdCustomer.Text = "Customer";
            // 
            // rdSupplier
            // 
            this.rdSupplier.Location = new System.Drawing.Point(548, 187);
            this.rdSupplier.Name = "rdSupplier";
            this.rdSupplier.Size = new System.Drawing.Size(62, 18);
            this.rdSupplier.TabIndex = 6;
            this.rdSupplier.Text = "Supplier";
            // 
            // rdOther
            // 
            this.rdOther.Location = new System.Drawing.Point(418, 188);
            this.rdOther.Name = "rdOther";
            this.rdOther.Size = new System.Drawing.Size(50, 18);
            this.rdOther.TabIndex = 8;
            this.rdOther.Text = "Other";
            // 
            // rdSalesman
            // 
            this.rdSalesman.Location = new System.Drawing.Point(474, 188);
            this.rdSalesman.Name = "rdSalesman";
            this.rdSalesman.Size = new System.Drawing.Size(68, 18);
            this.rdSalesman.TabIndex = 7;
            this.rdSalesman.Text = "Salesman";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(692, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 87;
            this.label5.Text = "Select Type";
            // 
            // AddEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 233);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdOther);
            this.Controls.Add(this.rdSalesman);
            this.Controls.Add(this.rdSupplier);
            this.Controls.Add(this.rdCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.radButtonCancel);
            this.Controls.Add(this.radButtonSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditAccount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account";
            this.ThemeName = "Office2010Blue";
            this.Load += new System.EventHandler(this.AddEditAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSalesman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Telerik.WinControls.UI.RadLabel lblTitle;
        private Telerik.WinControls.UI.RadTextBox txtTitle;
        private Telerik.WinControls.UI.RadButton radButtonCancel;
        private Telerik.WinControls.UI.RadButton radButtonSave;
        private Telerik.WinControls.UI.RadTextBox txtAddress;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtContact;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTextBox txtCode;
        private Telerik.WinControls.UI.RadRadioButton rdCustomer;
        private Telerik.WinControls.UI.RadRadioButton rdSupplier;
        private Telerik.WinControls.UI.RadRadioButton rdOther;
        private Telerik.WinControls.UI.RadRadioButton rdSalesman;
        private System.Windows.Forms.Label label5;
    }
}
