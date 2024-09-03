namespace POS_System.Forms
{
    partial class AddEditReceiptForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.ddlPaymentMethod = new Telerik.WinControls.UI.RadDropDownList();
            this.dtPaymentDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.lblTitle = new Telerik.WinControls.UI.RadLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.radButtonCancel = new Telerik.WinControls.UI.RadButton();
            this.radButtonSave = new Telerik.WinControls.UI.RadButton();
            this.txtRemarks = new Telerik.WinControls.UI.RadTextBox();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlCustomer = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDis = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPaymentMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            this.ddlPaymentMethod.Location = new System.Drawing.Point(445, 81);
            this.ddlPaymentMethod.Name = "ddlPaymentMethod";
            this.ddlPaymentMethod.Size = new System.Drawing.Size(253, 26);
            this.ddlPaymentMethod.TabIndex = 112;
            this.ddlPaymentMethod.ThemeName = "Office2010Blue";
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtPaymentDate.AutoSize = false;
            this.dtPaymentDate.BackColor = System.Drawing.Color.Transparent;
            this.dtPaymentDate.CustomFormat = "";
            this.dtPaymentDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dtPaymentDate.ForeColor = System.Drawing.Color.Black;
            this.dtPaymentDate.Location = new System.Drawing.Point(36, 48);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(253, 26);
            this.dtPaymentDate.TabIndex = 111;
            this.dtPaymentDate.TabStop = false;
            this.dtPaymentDate.Text = "Saturday, August 24, 2024";
            this.dtPaymentDate.ThemeName = "Office2010Blue";
            this.dtPaymentDate.Value = new System.DateTime(2024, 8, 24, 11, 21, 29, 981);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(372, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add Payment";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.ThemeName = "Office2010Blue";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(704, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 125;
            this.label4.Text = "Income Type";
            // 
            // radButtonCancel
            // 
            this.radButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonCancel.BackColor = System.Drawing.Color.White;
            this.radButtonCancel.Location = new System.Drawing.Point(254, 214);
            this.radButtonCancel.Name = "radButtonCancel";
            this.radButtonCancel.Size = new System.Drawing.Size(94, 32);
            this.radButtonCancel.TabIndex = 119;
            this.radButtonCancel.Text = "Close";
            this.radButtonCancel.ThemeName = "Office2010Blue";
            // 
            // radButtonSave
            // 
            this.radButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonSave.BackColor = System.Drawing.Color.White;
            this.radButtonSave.Location = new System.Drawing.Point(77, 214);
            this.radButtonSave.Name = "radButtonSave";
            this.radButtonSave.Size = new System.Drawing.Size(171, 32);
            this.radButtonSave.TabIndex = 118;
            this.radButtonSave.Text = "Save Changes";
            this.radButtonSave.ThemeName = "Office2010Blue";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtRemarks.Location = new System.Drawing.Point(37, 108);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            // 
            // 
            // 
            this.txtRemarks.RootElement.StretchVertically = true;
            this.txtRemarks.Size = new System.Drawing.Size(253, 60);
            this.txtRemarks.TabIndex = 117;
            this.txtRemarks.ThemeName = "Office2010Blue";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(295, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 19);
            this.label12.TabIndex = 121;
            this.label12.Text = "Date";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(296, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 124;
            this.label3.Text = "Remarks";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lblTitle);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(849, 33);
            this.radGroupBox1.TabIndex = 120;
            this.radGroupBox1.ThemeName = "TelerikMetroTouch";
            // 
            // ddlCustomer
            // 
            this.ddlCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddlCustomer.AutoSize = false;
            this.ddlCustomer.BackColor = System.Drawing.Color.Orange;
            this.ddlCustomer.DropDownMaxSize = new System.Drawing.Size(800, 300);
            this.ddlCustomer.DropDownMinSize = new System.Drawing.Size(800, 250);
            // 
            // ddlCustomer.NestedRadGridView
            // 
            this.ddlCustomer.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ddlCustomer.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCustomer.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ddlCustomer.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.ddlCustomer.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ddlCustomer.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ddlCustomer.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ddlCustomer.EditorControl.MasterTemplate.EnableGrouping = false;
            this.ddlCustomer.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ddlCustomer.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.ddlCustomer.EditorControl.Name = "NestedRadGridView";
            this.ddlCustomer.EditorControl.ReadOnly = true;
            this.ddlCustomer.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ddlCustomer.EditorControl.ShowGroupPanel = false;
            this.ddlCustomer.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.ddlCustomer.EditorControl.TabIndex = 0;
            this.ddlCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCustomer.ForeColor = System.Drawing.Color.White;
            this.ddlCustomer.Location = new System.Drawing.Point(445, 49);
            this.ddlCustomer.Name = "ddlCustomer";
            this.ddlCustomer.Size = new System.Drawing.Size(253, 26);
            this.ddlCustomer.TabIndex = 126;
            this.ddlCustomer.TabStop = false;
            this.ddlCustomer.ThemeName = "Office2010Blue";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(706, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 127;
            this.label5.Text = "Account";
            // 
            // txtDis
            // 
            this.txtDis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDis.AutoSize = false;
            this.txtDis.BackColor = System.Drawing.Color.Transparent;
            this.txtDis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtDis.ForeColor = System.Drawing.Color.Black;
            this.txtDis.Location = new System.Drawing.Point(36, 80);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(253, 26);
            this.txtDis.TabIndex = 128;
            this.txtDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDis.ThemeName = "Office2010Blue";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(295, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 129;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(704, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 131;
            this.label2.Text = "Reference";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTextBox1.AutoSize = false;
            this.radTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.radTextBox1.ForeColor = System.Drawing.Color.Black;
            this.radTextBox1.Location = new System.Drawing.Point(445, 113);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(253, 26);
            this.radTextBox1.TabIndex = 130;
            this.radTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.radTextBox1.ThemeName = "Office2010Blue";
            // 
            // AddEditReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.ddlCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddlPaymentMethod);
            this.Controls.Add(this.dtPaymentDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radButtonCancel);
            this.Controls.Add(this.radButtonSave);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditReceiptForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receipt";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.ddlPaymentMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadDropDownList ddlPaymentMethod;
        private Telerik.WinControls.UI.RadDateTimePicker dtPaymentDate;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.UI.RadLabel lblTitle;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadButton radButtonCancel;
        private Telerik.WinControls.UI.RadButton radButtonSave;
        private Telerik.WinControls.UI.RadTextBox txtRemarks;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ddlCustomer;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtDis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
    }
}
