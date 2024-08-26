namespace POS_System.Forms
{
    partial class StoreList
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
            this.dgInventories = new Telerik.WinControls.UI.RadGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgInventories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventories.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInventories
            // 
            this.dgInventories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInventories.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInventories.Location = new System.Drawing.Point(0, 46);
            // 
            // 
            // 
            this.dgInventories.MasterTemplate.AllowAddNewRow = false;
            this.dgInventories.MasterTemplate.AllowDeleteRow = false;
            this.dgInventories.MasterTemplate.AllowEditRow = false;
            this.dgInventories.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgInventories.MasterTemplate.EnableFiltering = true;
            this.dgInventories.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgInventories.Name = "dgInventories";
            this.dgInventories.Size = new System.Drawing.Size(1286, 477);
            this.dgInventories.TabIndex = 11;
            this.dgInventories.ThemeName = "Office2010Blue";
            this.dgInventories.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgInventories_CommandCellClick);
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
            this.radGroupBox1.Size = new System.Drawing.Size(1286, 46);
            this.radGroupBox1.TabIndex = 10;
            this.radGroupBox1.ThemeName = "Office2010Blue";
            // 
            // radButtonPrint
            // 
            this.radButtonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonPrint.BackColor = System.Drawing.Color.White;
            this.radButtonPrint.Location = new System.Drawing.Point(986, 9);
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
            this.lblTitle.Location = new System.Drawing.Point(616, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "My Stores";
            this.lblTitle.ThemeName = "TelerikMetroTouch";
            // 
            // radButton2
            // 
            this.radButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton2.BackColor = System.Drawing.Color.White;
            this.radButton2.Location = new System.Drawing.Point(1150, 9);
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
            this.radButton1.Location = new System.Drawing.Point(823, 9);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(161, 28);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "New Furniture";
            this.radButton1.ThemeName = "Office2010Blue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // StoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 523);
            this.Controls.Add(this.dgInventories);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StoreList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "My Store";
            this.ThemeName = "Office2010Blue";
            this.Load += new System.EventHandler(this.StoreList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInventories.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventories)).EndInit();
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

        private Telerik.WinControls.UI.RadGridView dgInventories;
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
