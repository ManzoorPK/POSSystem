namespace POS_System.Forms
{
    partial class InvoicesList
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgInvoices = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButtonPrint = new Telerik.WinControls.UI.RadButton();
            this.lblTitle = new Telerik.WinControls.UI.RadLabel();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.materialPinkTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInvoices
            // 
            this.dgInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInvoices.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInvoices.Location = new System.Drawing.Point(0, 46);
            // 
            // 
            // 
            this.dgInvoices.MasterTemplate.AllowAddNewRow = false;
            this.dgInvoices.MasterTemplate.AllowDeleteRow = false;
            this.dgInvoices.MasterTemplate.AllowEditRow = false;
            this.dgInvoices.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgInvoices.MasterTemplate.EnableFiltering = true;
            this.dgInvoices.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgInvoices.Name = "dgInvoices";
            this.dgInvoices.Size = new System.Drawing.Size(1584, 526);
            this.dgInvoices.TabIndex = 13;
            this.dgInvoices.ThemeName = "Office2010Blue";
            this.dgInvoices.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgInvoices_CommandCellClick);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.White;
            this.radGroupBox1.Controls.Add(this.radButtonPrint);
            this.radGroupBox1.Controls.Add(this.lblTitle);
            this.radGroupBox1.Controls.Add(this.radButton2);
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1584, 46);
            this.radGroupBox1.TabIndex = 12;
            this.radGroupBox1.ThemeName = "Office2010Blue";
            // 
            // radButtonPrint
            // 
            this.radButtonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonPrint.BackColor = System.Drawing.Color.White;
            this.radButtonPrint.Location = new System.Drawing.Point(1291, 9);
            this.radButtonPrint.Name = "radButtonPrint";
            this.radButtonPrint.Size = new System.Drawing.Size(161, 28);
            this.radButtonPrint.TabIndex = 4;
            this.radButtonPrint.Text = "Print (CTRL + P)";
            this.radButtonPrint.ThemeName = "Office2010Blue";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(653, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Sales Invoices";
            this.lblTitle.ThemeName = "TelerikMetroTouch";
            // 
            // radButton2
            // 
            this.radButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton2.BackColor = System.Drawing.Color.White;
            this.radButton2.Location = new System.Drawing.Point(1455, 9);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(124, 28);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "Close";
            this.radButton2.ThemeName = "Office2010Blue";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.BackColor = System.Drawing.Color.White;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButton1.ImageKey = "299068_add_sign_icon.png";
            this.radButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radButton1.Location = new System.Drawing.Point(1128, 9);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(161, 28);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "New Furniture";
            this.radButton1.ThemeName = "Office2010Blue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // InvoicesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 572);
            this.Controls.Add(this.dgInvoices);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "InvoicesList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Sales Invoices";
            this.ThemeName = "Office2010Blue";
            this.Load += new System.EventHandler(this.InvoicesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgInvoices;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButtonPrint;
        private Telerik.WinControls.UI.RadLabel lblTitle;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.Themes.MaterialPinkTheme materialPinkTheme1;
    }
}
