namespace POS_System.Forms
{
    partial class InvoicesFormWizard
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgInventories = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnReturnItems = new Telerik.WinControls.UI.RadButton();
            this.lblTitle = new Telerik.WinControls.UI.RadLabel();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.materialPinkTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlInvoices = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventories.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlInvoices.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlInvoices.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInventories
            // 
            this.dgInventories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInventories.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInventories.Location = new System.Drawing.Point(0, 104);
            // 
            // 
            // 
            this.dgInventories.MasterTemplate.AllowAddNewRow = false;
            this.dgInventories.MasterTemplate.AllowDeleteRow = false;
            this.dgInventories.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCheckBoxColumn1.HeaderText = "";
            gridViewCheckBoxColumn1.Name = "colSelect";
            gridViewCheckBoxColumn1.Width = 49;
            gridViewTextBoxColumn1.HeaderText = "";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ColInvoiceItemId";
            gridViewTextBoxColumn2.HeaderText = "Product";
            gridViewTextBoxColumn2.Name = "ColProduct";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 421;
            gridViewTextBoxColumn3.HeaderText = "Sale Price";
            gridViewTextBoxColumn3.Name = "ColSalePrice";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 97;
            gridViewTextBoxColumn4.HeaderText = "Qty";
            gridViewTextBoxColumn4.Name = "ColQty";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 99;
            gridViewTextBoxColumn5.HeaderText = "Total";
            gridViewTextBoxColumn5.Name = "ColTotal";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 176;
            this.dgInventories.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.dgInventories.MasterTemplate.EnableFiltering = true;
            this.dgInventories.MasterTemplate.ShowFilteringRow = false;
            this.dgInventories.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgInventories.Name = "dgInventories";
            this.dgInventories.ShowGroupPanel = false;
            this.dgInventories.Size = new System.Drawing.Size(860, 765);
            this.dgInventories.TabIndex = 13;
            this.dgInventories.ThemeName = "Office2010Blue";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.White;
            this.radGroupBox1.Controls.Add(this.btnReturnItems);
            this.radGroupBox1.Controls.Add(this.lblTitle);
            this.radGroupBox1.Controls.Add(this.radButton2);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(860, 47);
            this.radGroupBox1.TabIndex = 12;
            this.radGroupBox1.ThemeName = "Office2010Blue";
            // 
            // btnReturnItems
            // 
            this.btnReturnItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnItems.BackColor = System.Drawing.Color.White;
            this.btnReturnItems.Location = new System.Drawing.Point(585, 9);
            this.btnReturnItems.Name = "btnReturnItems";
            this.btnReturnItems.Size = new System.Drawing.Size(133, 28);
            this.btnReturnItems.TabIndex = 3;
            this.btnReturnItems.Text = "OK";
            this.btnReturnItems.ThemeName = "Office2010Blue";
            this.btnReturnItems.Click += new System.EventHandler(this.btnReturnItems_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(333, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Invoice Search";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblTitle.ThemeName = "TelerikMetroTouch";
            // 
            // radButton2
            // 
            this.radButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton2.BackColor = System.Drawing.Color.White;
            this.radButton2.Location = new System.Drawing.Point(724, 9);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(124, 28);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "Close";
            this.radButton2.ThemeName = "Office2010Blue";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.BackColor = System.Drawing.Color.White;
            this.radGroupBox2.Controls.Add(this.label6);
            this.radGroupBox2.Controls.Add(this.ddlInvoices);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.radGroupBox2.HeaderText = "";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 47);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(860, 57);
            this.radGroupBox2.TabIndex = 14;
            this.radGroupBox2.ThemeName = "Office2010Blue";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(512, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Select Invoice";
            // 
            // ddlInvoices
            // 
            this.ddlInvoices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddlInvoices.AutoSize = false;
            this.ddlInvoices.BackColor = System.Drawing.Color.Orange;
            this.ddlInvoices.DropDownMaxSize = new System.Drawing.Size(800, 300);
            this.ddlInvoices.DropDownMinSize = new System.Drawing.Size(800, 250);
            // 
            // ddlInvoices.NestedRadGridView
            // 
            this.ddlInvoices.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ddlInvoices.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlInvoices.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ddlInvoices.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.ddlInvoices.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ddlInvoices.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ddlInvoices.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ddlInvoices.EditorControl.MasterTemplate.EnableGrouping = false;
            this.ddlInvoices.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ddlInvoices.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.ddlInvoices.EditorControl.Name = "NestedRadGridView";
            this.ddlInvoices.EditorControl.ReadOnly = true;
            this.ddlInvoices.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ddlInvoices.EditorControl.ShowGroupPanel = false;
            this.ddlInvoices.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.ddlInvoices.EditorControl.TabIndex = 0;
            this.ddlInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlInvoices.ForeColor = System.Drawing.Color.White;
            this.ddlInvoices.Location = new System.Drawing.Point(214, 13);
            this.ddlInvoices.Name = "ddlInvoices";
            this.ddlInvoices.Size = new System.Drawing.Size(292, 26);
            this.ddlInvoices.TabIndex = 3;
            this.ddlInvoices.TabStop = false;
            this.ddlInvoices.ThemeName = "Office2010Blue";
            this.ddlInvoices.SelectedIndexChanged += new System.EventHandler(this.ddlInvoices_SelectedIndexChanged);
            // 
            // InvoicesFormWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 869);
            this.Controls.Add(this.dgInventories);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InvoicesFormWizard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invoices";
            this.ThemeName = "Office2010Blue";
            this.Load += new System.EventHandler(this.InvoicesFormWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInventories.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlInvoices.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlInvoices.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgInventories;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.Themes.MaterialPinkTheme materialPinkTheme1;
        private Telerik.WinControls.UI.RadLabel lblTitle;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ddlInvoices;
        private Telerik.WinControls.UI.RadButton btnReturnItems;
    }
}
