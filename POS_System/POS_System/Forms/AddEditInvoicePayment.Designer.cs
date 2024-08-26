namespace POS_System.Forms
{
    partial class AddEditInvoicePayment
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.radButtonCancel = new Telerik.WinControls.UI.RadButton();
            this.radButtonSave = new Telerik.WinControls.UI.RadButton();
            this.txtRemarks = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblTitle = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.txtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.dtPaymentDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.ddlPaymentMethod = new Telerik.WinControls.UI.RadDropDownList();
            this.txtPaid = new Telerik.WinControls.UI.RadTextBox();
            this.txtBalance = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPayNow = new Telerik.WinControls.UI.RadTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPaymentMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayNow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(292, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 104;
            this.label4.Text = "Payment Method";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(701, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 19);
            this.label12.TabIndex = 100;
            this.label12.Text = "Date";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(701, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 103;
            this.label3.Text = "Remarks";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(701, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 102;
            this.label2.Text = "Total";
            // 
            // radButtonCancel
            // 
            this.radButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonCancel.BackColor = System.Drawing.Color.White;
            this.radButtonCancel.Location = new System.Drawing.Point(211, 194);
            this.radButtonCancel.Name = "radButtonCancel";
            this.radButtonCancel.Size = new System.Drawing.Size(94, 32);
            this.radButtonCancel.TabIndex = 8;
            this.radButtonCancel.Text = "Close";
            this.radButtonCancel.ThemeName = "Office2010Blue";
            this.radButtonCancel.Click += new System.EventHandler(this.radButtonCancel_Click);
            // 
            // radButtonSave
            // 
            this.radButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonSave.BackColor = System.Drawing.Color.White;
            this.radButtonSave.Location = new System.Drawing.Point(34, 194);
            this.radButtonSave.Name = "radButtonSave";
            this.radButtonSave.Size = new System.Drawing.Size(171, 32);
            this.radButtonSave.TabIndex = 7;
            this.radButtonSave.Text = "Save Changes";
            this.radButtonSave.ThemeName = "Office2010Blue";
            this.radButtonSave.Click += new System.EventHandler(this.radButtonSave_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtRemarks.Location = new System.Drawing.Point(33, 128);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            // 
            // 
            // 
            this.txtRemarks.RootElement.StretchVertically = true;
            this.txtRemarks.Size = new System.Drawing.Size(662, 60);
            this.txtRemarks.TabIndex = 6;
            this.txtRemarks.ThemeName = "Office2010Blue";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(550, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "Paid";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lblTitle);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(796, 33);
            this.radGroupBox1.TabIndex = 99;
            this.radGroupBox1.ThemeName = "TelerikMetroTouch";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(301, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add Payment";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblTitle.ThemeName = "Office2010Blue";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtTotal.Location = new System.Drawing.Point(604, 90);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(91, 29);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.ThemeName = "Office2010Blue";
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtPaymentDate.AutoSize = false;
            this.dtPaymentDate.BackColor = System.Drawing.Color.Transparent;
            this.dtPaymentDate.CustomFormat = "";
            this.dtPaymentDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dtPaymentDate.ForeColor = System.Drawing.Color.Black;
            this.dtPaymentDate.Location = new System.Drawing.Point(442, 58);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(253, 26);
            this.dtPaymentDate.TabIndex = 0;
            this.dtPaymentDate.TabStop = false;
            this.dtPaymentDate.Text = "Saturday, August 24, 2024";
            this.dtPaymentDate.ThemeName = "Office2010Blue";
            this.dtPaymentDate.Value = new System.DateTime(2024, 8, 24, 11, 21, 29, 981);
            // 
            // ddlPaymentMethod
            // 
            this.ddlPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddlPaymentMethod.AutoSize = false;
            this.ddlPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.ddlPaymentMethod.DropDownAnimationEnabled = true;
            this.ddlPaymentMethod.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ddlPaymentMethod.ForeColor = System.Drawing.Color.Black;
            radListDataItem1.Text = "Regular";
            radListDataItem2.Text = "Whole Sale";
            this.ddlPaymentMethod.Items.Add(radListDataItem1);
            this.ddlPaymentMethod.Items.Add(radListDataItem2);
            this.ddlPaymentMethod.Location = new System.Drawing.Point(33, 58);
            this.ddlPaymentMethod.Name = "ddlPaymentMethod";
            this.ddlPaymentMethod.Size = new System.Drawing.Size(253, 26);
            this.ddlPaymentMethod.TabIndex = 1;
            this.ddlPaymentMethod.ThemeName = "Office2010Blue";
            // 
            // txtPaid
            // 
            this.txtPaid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPaid.BackColor = System.Drawing.Color.White;
            this.txtPaid.Enabled = false;
            this.txtPaid.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPaid.Location = new System.Drawing.Point(442, 90);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.ReadOnly = true;
            this.txtPaid.Size = new System.Drawing.Size(91, 29);
            this.txtPaid.TabIndex = 3;
            this.txtPaid.ThemeName = "Office2010Blue";
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtBalance.Location = new System.Drawing.Point(195, 90);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(91, 29);
            this.txtBalance.TabIndex = 4;
            this.txtBalance.ThemeName = "Office2010Blue";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(292, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 108;
            this.label5.Text = "Balance";
            // 
            // txtPayNow
            // 
            this.txtPayNow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPayNow.BackColor = System.Drawing.Color.Orange;
            this.txtPayNow.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.txtPayNow.ForeColor = System.Drawing.Color.White;
            this.txtPayNow.Location = new System.Drawing.Point(34, 90);
            this.txtPayNow.Name = "txtPayNow";
            this.txtPayNow.Size = new System.Drawing.Size(91, 29);
            this.txtPayNow.TabIndex = 5;
            this.txtPayNow.ThemeName = "Office2010Blue";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(126, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 110;
            this.label6.Text = "Pay Now";
            // 
            // AddEditInvoicePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 237);
            this.Controls.Add(this.txtPayNow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.ddlPaymentMethod);
            this.Controls.Add(this.dtPaymentDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radButtonCancel);
            this.Controls.Add(this.radButtonSave);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.txtTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditInvoicePayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invoice Payments";
            this.ThemeName = "Office2010Blue";
            this.Load += new System.EventHandler(this.AddEditInvoicePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPaymentMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayNow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.UI.RadButton radButtonCancel;
        private Telerik.WinControls.UI.RadButton radButtonSave;
        private Telerik.WinControls.UI.RadTextBox txtRemarks;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel lblTitle;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.UI.RadTextBox txtTotal;
        private Telerik.WinControls.UI.RadDateTimePicker dtPaymentDate;
        private Telerik.WinControls.UI.RadDropDownList ddlPaymentMethod;
        private Telerik.WinControls.UI.RadTextBox txtPaid;
        private Telerik.WinControls.UI.RadTextBox txtBalance;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtPayNow;
        private System.Windows.Forms.Label label6;
    }
}
