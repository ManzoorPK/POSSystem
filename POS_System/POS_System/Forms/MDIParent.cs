
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SuperAisaStoreV1;
using POS_System.Forms;

namespace POS_System
{
    public partial class MDIParent : Telerik.WinControls.UI.RadForm
    {
        int _POID = 0;
        public MDIParent()
        {
            InitializeComponent();
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new System.Drawing.Size(w, h);

            LoadToolBarButtons();

            DashboardForm frm = new DashboardForm();
            frm.MdiParent = this;
            frm.Show();

            //LoginForm login = new LoginForm();
            //login.ShowDialog();

        }

        public void CloseAllChildForms()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            //LoadToolBarButtons();

            //DashboardForm frm = new DashboardForm();
            //frm.MdiParent = this;
            //frm.Show();

            //LoginForm login = new LoginForm();
            //login.ShowDialog();

        }
        private void radRibbonBarGroup14_Click(object sender, EventArgs e)
        {

        }
        void LoadToolBarButtons()
        {
            SetToolBarImage(toolBarDashboard, "1.png", "Dashbord");
            SetToolBarImage(toolBarSalesReport, "1.png", "Sales Dashbord");
            SetToolBarImage(toolBarProducts, "products.png", "View Products");
            SetToolBarImage(toolBarAddProducts, "addproduct.png", "Add new Product");
            SetToolBarImage(toolBarSuppliers, "suppliers.png", "View Suppliers");
            SetToolBarImage(toolBarPurchaseOrders, "PO.png", "Add new Purchase Order");
            SetToolBarImage(toolbarAddnewPurchase, "addPO.png", "Add new Purchase Order");
            SetToolBarImage(toolbarPaySupplier, "payment.png", "Pay Supplier");
            SetToolBarImage(toolbarRecievePaymentCustomer, "payment.png", "Receive Payment From Customer");
            SetToolBarImage(toolbarRefresh, "refresh.png", "Refresh Suppliers etc");
            SetToolBarImage(toolBarReturnPOList, "return.png", "View Return Purchases");
            SetToolBarImage(toolbarReturnPO, "returnPO.png", "Add Return Purchases");
            SetToolBarImage(toolbarInvoices, "Invoices.png", "View All Invoices");
            SetToolBarImage(toolbarnewInvoice, "attach.png", "Add new Invoice");
            SetToolBarImage(toolBarCustomers, "customers.png", "View All Customers");
            SetToolBarImage(toolbarViewReturnInvoices, "returnInvoice.png", "View Return Invoices");
            SetToolBarImage(toolbarAddnewReturnInvoice, "addreturninvoice.png", "Add Return Invoice");
            
            //LoadPO();
            LoadSuppliers();
            LoadCustomers();
            LoadInvoices();
        }

        void LoadCustomers()
        {
            //var cust = new CustomerHelper().GetAllCustomers();
            //cust.Insert(0, new Models.Customer { Name = "" });

            //ddlCustomer.DataSource = cust;
            //this.ddlCustomer.AutoFilter = true;
            //this.ddlCustomer.DisplayMember = "Name";
            //this.ddlCustomer.ValueMember = "CustomerId";
            //FilterDescriptor filter = new FilterDescriptor();
            //filter.PropertyName = this.ddlCustomer.DisplayMember;
            //filter.Operator = FilterOperator.Contains;
            //this.ddlCustomer.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            //foreach (var col in this.ddlCustomer.Columns)
            //{
            //    col.Width = 200;
            //    col.TextAlignment = ContentAlignment.MiddleLeft;
            //    col.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            //}

            //ddlCustomer.Columns[0].IsVisible = false;
            //ddlCustomer.Columns[5].IsVisible = false;
            //ddlCustomer.Columns[7].IsVisible = false;
            //ddlCustomer.Columns[2].HeaderText = "Mobile #";
            //ddlCustomer.Columns[3].HeaderText = "Ph #";
            //ddlCustomer.Columns[6].HeaderText = "Closing Balance";
            //ddlCustomer.Columns[6].FormatString = Common.StringFormat();
            //ddlCustomer.Columns[2].Width = 80;
            //ddlCustomer.Columns[3].Width = 80;
            //ddlCustomer.Columns[6].Width = 100;
        }
        void LoadSuppliers()
        {
        //    var cust = new SupplierHelper().GetAllSuppliers();
        //    cust.Insert(0, new SupplierV { Address = "", CellNo = "", ContactPerson = "", Note = "", PhoneNo = "", Supplier = "", SupplierId = 0 });
        //    ddlSupLedgers.DataSource = cust;
        //    this.ddlSupLedgers.AutoFilter = true;
        //    this.ddlSupLedgers.ValueMember = "SupplierId";
        //    this.ddlSupLedgers.DisplayMember = "Supplier";

        //    FilterDescriptor filter = new FilterDescriptor();
        //    filter.PropertyName = this.ddlSupLedgers.DisplayMember;
        //    filter.Operator = FilterOperator.Contains;
        //    this.ddlSupLedgers.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
        //    //this.ddlSuppliers.AutoSizeDropDownToBestFit = true;

        //    foreach (var col in this.ddlSupLedgers.Columns)
        //    {
        //        col.Width = 150;
        //        col.TextAlignment = ContentAlignment.MiddleLeft;
        //        col.HeaderTextAlignment = ContentAlignment.MiddleLeft;
        //    }

        //    ddlSupLedgers.Columns[0].IsVisible = false;
        //    ddlSupLedgers.Columns[6].IsVisible = false;
        //    ddlSupLedgers.Columns[8].IsVisible = false;
        //    ddlSupLedgers.Columns[1].HeaderText = "Name";
        //    ddlSupLedgers.Columns[2].HeaderText = "Ph #";
        //    ddlSupLedgers.Columns[3].HeaderText = "Mobile #";
        //    ddlSupLedgers.Columns[5].HeaderText = "Contact Person";
        //    ddlSupLedgers.Columns[7].HeaderText = "Closing Balance";
        //    ddlSupLedgers.Columns[7].FormatString = Common.StringFormat();
        //    ddlSupLedgers.Columns[2].Width = 80;
        //    ddlSupLedgers.Columns[3].Width = 80;

        //    ddlSupLedgers.SelectedValue = 0;
        //}

        //void LoadPO()
        //{
        //    var _Data = new POHelper().GetAllPOs();
        //    _Data.Insert(0, new Models.PurchaseOrderV { POID = 0 });

        //    var obj = (from a in  _Data
        //               select new
        //               {
        //                   a.POID,
        //                   Date = Convert.ToDateTime(a.Date).ToString("dd/MM/yyyy"),
        //                   a.Supplier,
        //                   a.ReferenceNo,
        //                   Total = "Rs. " + Common.GetAsMoneyWithComma(a.TotalAmount).ToString(),
        //                   Paid = "Rs. " + Common.GetAsMoneyWithComma(a.TotalPaid).ToString(),
        //                   Balance = "Rs. " + Common.GetAsMoneyWithComma(a.Net),
        //                   Searcho = a.POID.ToString() + " " + a.Supplier
        //               }).ToList();

        //    ddlSearchPO.DataSource = obj;
        //    this.ddlSearchPO.AutoFilter = true;
        //    this.ddlSearchPO.ValueMember = "POID";
        //    this.ddlSearchPO.DisplayMember = "Supplier";

        //    FilterDescriptor filter = new FilterDescriptor();
        //    filter.PropertyName = "Searcho"; //this.ddlSearchPO.DisplayMember;
        //    filter.Operator = FilterOperator.Contains;
        //    this.ddlSearchPO.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);


        //    foreach (var col in this.ddlSearchPO.Columns)
        //    {
        //        col.Width = 80;
        //        col.TextAlignment = ContentAlignment.MiddleLeft;
        //        col.HeaderTextAlignment = ContentAlignment.MiddleLeft;
        //    }
           
        //    ddlSearchPO.Columns[0].HeaderText = "PO #";
        //    ddlSearchPO.Columns[3].HeaderText = "Ref #";

        //    ddlSearchPO.Columns[2].Width = 170;
        //    ddlSearchPO.Columns[7].IsVisible = false;

        //    ddlSearchPO.SelectedValue = 0;
        }

        void LoadInvoices()
        {
            //var _Data = new InvoiceHelper().GetAllInvoices();
            //_Data.Insert(0, new Models.InvoiceV { InvoiceId = 0 });
            //var obj = (from a in _Data
            //           select new
            //           {
            //               a.InvoiceId,
            //               Date = Convert.ToDateTime(a.Date).ToString("dd/MM/yyyy"),
            //               a.Name,
            //               Total = "Rs. " + Common.GetAsMoneyWithComma(a.TotalPayment).ToString(),
            //               Paid = "Rs. " + Common.GetAsMoneyWithComma(a.Paid).ToString(),
            //               Balance = "Rs. " + Common.GetAsMoneyWithComma(a.Balance),
            //               Searcho = a.InvoiceId.ToString() + " " + a.Name
            //           }).ToList();
            //ddlInvoiceNumberSearch.DataSource = obj;
            //this.ddlInvoiceNumberSearch.AutoFilter = true;
            //this.ddlInvoiceNumberSearch.ValueMember = "InvoiceId";
            //this.ddlInvoiceNumberSearch.DisplayMember = "Name";

            //FilterDescriptor filter = new FilterDescriptor();
            //filter.PropertyName = "Searcho"; //this.ddlSearchPO.DisplayMember;
            //filter.Operator = FilterOperator.Contains;
            //this.ddlInvoiceNumberSearch.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);


            //foreach (var col in this.ddlInvoiceNumberSearch.Columns)
            //{
            //    col.Width = 80;
            //    col.TextAlignment = ContentAlignment.MiddleLeft;
            //    col.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            //}

            //ddlInvoiceNumberSearch.Columns[0].HeaderText = "Invoice #";
            //ddlInvoiceNumberSearch.Columns[2].Width = 170;
            //ddlInvoiceNumberSearch.Columns[6].IsVisible = false;
            //ddlInvoiceNumberSearch.SelectedValue = 0;
        }
        private void SetToolBarButtons(RadButtonElement btn, string imageName, string tooltip, int height = 50, int width = 50)
        {
            btn.Image = General.ResizePicture(imageName, width, height);
            btn.ImageAlignment = ContentAlignment.MiddleCenter;
            btn.ToolTipText = tooltip;
        }
        private void SetToolBarImage(CommandBarButton btn, string imageName, string tooltip, int height = 25, int width = 25)
        {
            btn.Image = General.ResizePicture(imageName, width, height);
            btn.ImageAlignment = ContentAlignment.MiddleCenter;
            btn.ToolTipText = tooltip;
        }


        private void radRibbonBarGroup15_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            //CustomersList frm = new CustomersList(this);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void radRibbonBarGroup14_Click_1(object sender, EventArgs e)
        {
            CloseAllChildForms();
            //POList frm = new POList();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void IconPO_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            //POList frm = new POList();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void ribbonTab3_Click(object sender, EventArgs e)
        {

        }

        private void radRibbonBarGroup16_Click(object sender, EventArgs e)
        {
            
        }

        private void radButtonElementPOLedger_Click(object sender, EventArgs e)
        {
             
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolBarDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm frm = new DashboardForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MDIParent_MdiChildActivate(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild == null)
                tabForms1.Visible = false;
            // If no any child form, hide tabControl 
            else
            {
                this.ActiveMdiChild.WindowState =
                FormWindowState.Maximized;
                //// Child form always maximized 

                // If child form is new and no has tabPage, 
                // create new tabPage 
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child 
                    // form caption 
                    // form caption 
                    RadPageViewPage tp = new RadPageViewPage(this.ActiveMdiChild
                                             .Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms1;
                    tabForms1.SelectedPage = tp;
                    //((RadPageViewStripElement)tabForms1.ViewElement).StripButtons |= ~StripViewButtons.Close;
                    ((RadPageViewStripElement)tabForms1.ViewElement).StripButtons |= ~StripViewButtons.All;
                    //((RadPageViewStripElement)tabForms1.ViewElement).ShowItemCloseButton = false;
                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed +=
                        new FormClosedEventHandler(
                                        ActiveMdiChild_FormClosed);
                }
                if (!tabForms1.Visible) tabForms1.Visible = true;

            }
        }

        private void ActiveMdiChild_FormClosed(object sender,
                                    FormClosedEventArgs e)
        {
            ((sender as Form).Tag as RadPageViewPage).Dispose();
        }

        private void toolBarProducts_Click(object sender, EventArgs e)
        {
            //InventoriesList frm = new InventoriesList("");
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void toolBarAddProducts_Click(object sender, EventArgs e)
        {
            //AddEditInventory frm = new AddEditInventory(null, 0, this);
            //frm.ShowDialog();
        }

        private void tabForms1_SelectedPageChanged(object sender, EventArgs e)
        {
            if ((tabForms1.SelectedPage != null) &&
        (tabForms1.SelectedPage.Tag != null))
                (tabForms1.SelectedPage.Tag as Form).Select();
        }

        private void toolBarSuppliers_Click(object sender, EventArgs e)
        {
            //SupplierList frm = new SupplierList((MDIParent)this.MdiParent);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void toolBarPurchaseOrders_Click(object sender, EventArgs e)
        {
            //POList frm = new POList();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void toolbarAddnewPurchase_Click(object sender, EventArgs e)
        {
            //AddEditPO frm = new AddEditPO(null, 0,this);
            //frm.MdiParent = this;
            //frm.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.S))
            {
                ddlSupLedgers.Focus();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.P))
            {
                ddlSearchPO.Focus();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.I))
            {
                ddlInvoiceNumberSearch.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ddlSearchPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ddlSearchPO_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //AddEditPO frm = new AddEditPO(null, Convert.ToInt32(ddlSearchPO.SelectedValue),this);
                //frm.MdiParent = this;
                //frm.Show();
            }
        }

        private void ddlSupLedgers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //POLedger frm = new POLedger(Convert.ToInt32(ddlSupLedgers.SelectedValue));
                //frm.MdiParent = this;
                //frm.Show();
            }
        }

        private void toolbarPaySupplier_Click(object sender, EventArgs e)
        {
            //AddSupplierLedgerPayment frm = new AddSupplierLedgerPayment(null, 0);
            //frm.ShowDialog();
        }

        public void RefreshWork()
        {
            LoadSuppliers();
            //LoadPO();
            LoadCustomers();
            LoadInvoices();
        }
        private void toolbarRefresh_Click(object sender, EventArgs e)
        {
            RefreshWork();
        }

        private void MDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolBarReturnPO_Click(object sender, EventArgs e)
        {
            //AddEditPOReturn frm = new AddEditPOReturn(null, 0);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void toolBarReturnPOList_Click(object sender, EventArgs e)
        {
            //POReturnList frm = new POReturnList();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void ddlSupLedgers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolbarInvoices_Click(object sender, EventArgs e)
        {
            //InvoiceList frm = new InvoiceList();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void toolbarnewInvoice_Click(object sender, EventArgs e)
        {
            //AddEditInvoice frm = new AddEditInvoice(null, 0, this);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void toolBarCustomers_Click(object sender, EventArgs e)
        {
            //CustomersList frm = new CustomersList(this);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void toolbarViewReturnInvoices_Click(object sender, EventArgs e)
        {
            //ReturnInvoiceList frm = new ReturnInvoiceList();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void toolbarAddnewReturnInvoice_Click(object sender, EventArgs e)
        {
            //AddEditReturnInvoice frm = new AddEditReturnInvoice(null, 0);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void ddlInvoiceNumberSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //AddEditInvoice frm = new AddEditInvoice(null, Convert.ToInt32(ddlInvoiceNumberSearch.SelectedValue), this);
                //frm.MdiParent = this;
                //frm.Show();
            }
        }
        private void ddlCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //CustomerLedger frm = new CustomerLedger(Convert.ToInt32(ddlCustomer.SelectedValue));
                //frm.MdiParent = this;
                //frm.Show();
            }
        }

        private void toolbarRecievePaymentCustomer_Click(object sender, EventArgs e)
        {
            //AddCustomerLedgerPayment frm = new AddCustomerLedgerPayment(null, 0);
            //frm.ShowDialog();   
        }

        private void toolBarSalesReport_Click(object sender, EventArgs e)
        {
            //ReportDashboard frm = new ReportDashboard();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            StoreList frm = new StoreList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void radMenuItem6_Click(object sender, EventArgs e)
        {
            PaymentOptionsList frm = new PaymentOptionsList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseList frm = new WarehouseList();    
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuSaleInvoices_Click(object sender, EventArgs e)
        {
            InvoicesList frm = new InvoicesList("Sales Invoice");
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuSalesInvoice_Click(object sender, EventArgs e)
        {
            InvoicesList frm = new InvoicesList("Sales Return Invoice");
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
