using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace POS_System.Forms
{
    public partial class AddEditInvoiceForm : Telerik.WinControls.UI.RadForm
    {
        decimal MinPrice = 0;
        int InvoiceID = 0;
        decimal _AQty = 0;
        decimal _TotalPayables = 0;
        decimal _TotalBalance = 0;
        decimal _DiscountAmount = 0;
        decimal _AdditionalAmount = 0;
        bool SaveOnlyInvoice = false;
        InvoicesList IL;
        public AddEditInvoiceForm(InvoicesList iL, int _InvoiceId)
        {
            InitializeComponent();
            dtInvoiceDate.Value = DateTime.Now;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new System.Drawing.Size(w, h);
            IL = iL;
            InvoiceID = _InvoiceId;
        }
        public AddEditInvoiceForm()
        {
            InitializeComponent();
            dtInvoiceDate.Value = DateTime.Now;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new System.Drawing.Size(w, h);

        }
        private void AddEditInvoiceForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadProducts();
            LoadDropdownButtons();
            LoadPaymentMethod();
            LoadInvoiceDetails();

            new GridHelper().SetButton(btnAddItem, "add1.png", 30, 30);
            btnAddItem.ImageAlignment = ContentAlignment.MiddleCenter;
            btnAddItem.Padding = new Padding(0, 0, 0, 0);
            ddlInvoiceType.SelectedIndex = 0;

            new GridHelper().SetButton(radButtonSave, "save.png", 15, 15);
            new GridHelper().SetButton(radButtonCancel, "back.png", 15, 15);


            if (InvoiceID > 0)
                LoadInvoiceItems();
        }
        void LoadPaymentMethod()
        {
            ddlPaymentMethod.DataSource = new PaymentOptionHelper().GetAllPaymentOptions();
            ddlPaymentMethod.DisplayMember = "Title";
            ddlPaymentMethod.ValueMember = "PaymentOptionsId";
        }
        void CalculateDiscount()
        {
            if (InvoiceID > 0)
            {
                decimal _Discount = 0;
                if (txtDis.Text != "")
                    _Discount = Convert.ToDecimal(txtDis.Text);

                _DiscountAmount = (_Discount / 100) * (_TotalPayables + (txtTotalPrice.Text == "" ? 0 : Convert.ToDecimal(txtTotalPrice.Text)));

                lblDis.Text = Common.GetAsMoneyWithComma(_DiscountAmount);

                var _Total = _TotalPayables + (txtTotalPrice.Text == "" ? 0 : Convert.ToDecimal(txtTotalPrice.Text)) - _DiscountAmount + _AdditionalAmount;
                lblTotalPay.Text =  Common.GetAsMoneyWithComma(_Total); 
                //var _TotB = _TotalBalance + (txtTotalPrice.Text == "" ? 0 : Convert.ToDecimal(txtTotalPrice.Text)) - _DiscountAmount + _AdditionalAmount;
                //lblBalance.Text = Common.GetAsMoneyWithComma(_TotB);
            }
        }
        void CalculateAdditional()
        {
            if (InvoiceID > 0)
            {
                decimal _Discount = 0;
                if (txtAdditional.Text != "")
                    _Discount = Convert.ToDecimal(txtAdditional.Text);

                _AdditionalAmount = (_Discount / 100) * (_TotalPayables + (txtTotalPrice.Text == "" ? 0 : Convert.ToDecimal(txtTotalPrice.Text)));

                lblAdditional.Text = Common.GetAsMoneyWithComma(_AdditionalAmount);
                var _Total = _TotalPayables  + (txtTotalPrice.Text == "" ? 0 : Convert.ToDecimal(txtTotalPrice.Text)) - _DiscountAmount + _AdditionalAmount;
                lblTotalPay.Text = Common.GetAsMoneyWithComma(_Total);
                //var _TotB = _TotalBalance +   (_Discount / 100 * (txtTotalPrice.Text == "" ? 0 : Convert.ToDecimal(txtTotalPrice.Text)));
                //lblBalance.Text = Common.GetAsMoneyWithComma(_TotB);
            }
        }
        public void LoadInvoiceDetails()
        {
            var obj = new InvoiceHelper().GetInvoiceById(InvoiceID);
            if (obj != null)
            {
               

                lblTotal.Text = Common.GetAsMoneyWithComma(obj.TotalPayment);
                lblTotalPay.Text = Common.GetAsMoneyWithComma(obj.FinalTotal);
                lblTotalPaid.Text = Common.GetAsMoneyWithComma(obj.Paid);
                lblBalance.Text = Common.GetAsMoneyWithComma(obj.Balance);
                _TotalPayables = Convert.ToDecimal( obj.TotalPayment);
                _TotalBalance = Convert.ToDecimal(obj.Balance);

                CalculateDiscount();
                CalculateAdditional();  

                txtAdditional.Text = obj.Additional == null ? "" :Common.GetAsMoneyWithComma( obj.Additional).ToString();
                txtDis.Text = obj.Discount == null ? "" : Common.GetAsMoneyWithComma( obj.Discount).ToString();
                lblAdditional.Text = obj.AdditionalAmount == null ? "0" :Common.GetAsMoneyWithComma( obj.AdditionalAmount).ToString();   
                lblDis.Text = obj.DiscountAmount == null ? "0" : Common.GetAsMoneyWithComma( obj.DiscountAmount).ToString();


                if (obj.Balance == obj.FinalTotal)
                {
                    lblStatus.Text = "Due";
                    lblStatus.ForeColor = Color.OrangeRed;
                }
                else
                {
                    if (obj.Balance == 0 || obj.Balance > obj.FinalTotal)
                    {
                        lblStatus.Text = "Fully Paid";
                        lblStatus.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        if (obj.Balance < (obj.FinalTotal))
                        {
                            lblStatus.Text = "Partially Paid";
                            lblStatus.ForeColor = Color.Orange;
                        }
                    }
                }

               
                ddlCustomer.SelectedValue = Convert.ToInt32(obj.AccountId);
                this.Text = "Sales Invoice | Inv # :" + obj.InvoiceId.ToString();
                dtInvoiceDate.Value = Convert.ToDateTime(obj.Date);
                ddlInvoiceType.SelectedValue = obj.Type;
            }

            LoadInvoicePayments();

            if (InvoiceID > 0)
                btnAddItem.Enabled = true;
            else
                btnAddItem.Enabled = false;


        }
        void LoadInvoicePayments()
        {
            dgInvoicePayments.Columns.Clear();
            var obj = new InvoicePaymentHelper().GetInvoicePayment(InvoiceID);
            var _Data = from a in obj
                        select new
                        {
                            a.InvoicePaymentId,
                            Date = Convert.ToDateTime(a.Date).ToString("dd-MM-yyyy"),
                            Method = a.Title,
                            Total = Common.GetAsMoneyWithComma(a.Total),
                            Paid = Common.GetAsMoneyWithComma(a.Paid),
                            Balance = Common.GetAsMoneyWithComma(a.Balance)
                        };

            dgInvoicePayments.DataSource = _Data;
            //dgInvoicePayments.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnEdit", "", 100, "InvoiceItemId", 30, 13)));
            dgInvoicePayments.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnDeleteIconOnly", "", 100, "InvoiceItemId", 16, 16)));
            dgInvoicePayments.TableElement.RowHeight = 20;
            dgInvoicePayments.CellFormatting += new CellFormattingEventHandler(new GridHelper().GridCellFormatting);
            dgInvoicePayments.ShowFilteringRow = false;
            if (dgInvoicePayments.Rows.Count > 0)
            {
                dgInvoicePayments.Columns[0].IsVisible = false;
                dgInvoicePayments.Columns[1].Width = 70;
                dgInvoicePayments.Columns[2].Width = 80;
                dgInvoicePayments.Columns[3].Width = 50;
                dgInvoicePayments.Columns[4].Width = 50;
                dgInvoicePayments.Columns[5].Width = 50;
                dgInvoicePayments.Columns[6].Width = 30;
            }

            new GridHelper().SetGridHeaderAlignment(dgInvoicePayments, ContentAlignment.MiddleLeft);
        }
        void LoadDropdownButtons()
        {
            BottomView view = new BottomView("Add new Account", 40);
            ddlCustomer.EditorControl.GridViewElement.Panel.Children.Insert(0, view);
            view.SetValue(DockLayoutPanel.DockProperty, Telerik.WinControls.Layouts.Dock.Bottom);
            view.Button1.Click += button1_Click;
            new GridHelper().SetInnerButton(view.Button1, "Customers.png", 40, 40);

            BottomView view1 = new BottomView("Add new Product", 40);
            ddlProducts.EditorControl.GridViewElement.Panel.Children.Insert(0, view1);
            view1.SetValue(DockLayoutPanel.DockProperty, Telerik.WinControls.Layouts.Dock.Bottom);
            view1.Button1.Click += button2_Click;
            new GridHelper().SetInnerButton(view1.Button1, "add.png", 40, 40);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddEditAccount frm = new AddEditAccount(this, 0, "Invoice");
            frm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddEditInventory frm = new AddEditInventory(this);
            frm.ShowDialog();
        }
        void GetAccountDetails(int Id)
        {
            txtMobNo.Text = "";
            //txtAddress.Text = "";
            txtCode.Text = "";
            var obj = new AccountHelper().GetAccountById(Id);
            if (obj != null)
            {
                //txtAddress.Text = obj.Address;
                txtMobNo.Text = obj.CellNo;
                txtCode.Text = obj.AccountCode;
            }
        }

        void GetProductDetails(int Id)
        {
            txtSalePrice.Text = "";
            txtQty.Text = "";
            txtTotalPrice.Text = "";
            var obj = new ProductHelper().GetProductById(Id);
            if (obj != null)
            {
                if (ddlInvoiceType.SelectedIndex == 0)
                    txtSalePrice.Text = obj.SalePrice == null ? "0" : obj.SalePrice.ToString().Split('.')[0].ToString();
                else
                    txtSalePrice.Text = obj.WholeSalePrice == null ? "0" : obj.WholeSalePrice.ToString().Split('.')[0].ToString();

                MinPrice = Convert.ToDecimal(obj.MinSalePrice);
                _AQty = Convert.ToDecimal(obj.TotalQuantity);
            }
        }

        void CalculateTotal()
        {
            decimal _SalePrice = 0;
            decimal _Qty = 0;
            if (txtSalePrice.Text != "")
                _SalePrice = Convert.ToDecimal(txtSalePrice.Text);

            if (txtQty.Text != "")
                _Qty = Convert.ToDecimal(txtQty.Text);

            var Total = _Qty * _SalePrice;
            txtTotalPrice.Text = Total.ToString().Split('.')[0].ToString();
        }
        public void LoadCustomers(int Id = 0)
        {

            var cust = new AccountHelper().GetAllAccounts();
            cust.Insert(0, new Model.Account { Title = "" });

            ddlCustomer.DataSource = cust;
            this.ddlCustomer.AutoFilter = true;
            this.ddlCustomer.DisplayMember = "Title";
            this.ddlCustomer.ValueMember = "AccountId";
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.ddlCustomer.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.ddlCustomer.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            foreach (var col in this.ddlCustomer.Columns)
            {
                col.Width = 200;
                col.TextAlignment = ContentAlignment.MiddleLeft;
                col.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            }

            ddlCustomer.Columns[0].IsVisible = false;
            ddlCustomer.Columns[4].IsVisible = false;
            ddlCustomer.Columns[5].IsVisible = false;
            ddlCustomer.Columns[6].IsVisible = false;
            ddlCustomer.Columns[7].IsVisible = false;
            ddlCustomer.Columns[8].IsVisible = false;
            ddlCustomer.Columns[10].IsVisible = false;
            ddlCustomer.Columns[1].HeaderText = "Code";
            ddlCustomer.Columns[1].Width = 160;

            if (Id > 0)
            {
                ddlCustomer.SelectedValue = Id;
                GetAccountDetails(Id);
            }

        }
        public void LoadProducts(int Id = 0)
        {

            var _Data = new ProductHelper().GetAllProducts();
            _Data.Insert(0, new Model.Product { Title = "" });


            var obj = (from a in _Data
                       select new
                       {
                           a.ProductId,
                           a.Title,
                           a.Barcode,
                           a.Code1,
                           RPrice = Common.GetAsMoneyWithComma(a.RetailPrice).ToString(),
                           SPrice = Common.GetAsMoneyWithComma(a.SalePrice),
                           MPrice = Common.GetAsMoneyWithComma(a.MinSalePrice),
                           WPrice = Common.GetAsMoneyWithComma(a.WholeSalePrice).ToString(),
                           Searcho = a.ProductId.ToString() + " " + a.Title + " " + a.Barcode + " " + a.Code1
                       }).ToList();

            ddlProducts.DataSource = obj;
            this.ddlProducts.AutoFilter = true;
            this.ddlProducts.DisplayMember = "Title";
            this.ddlProducts.ValueMember = "ProductId";
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = "Searcho"; //this.ddlProducts.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.ddlProducts.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            foreach (var col in this.ddlProducts.Columns)
            {
                col.Width = 100;
                col.TextAlignment = ContentAlignment.MiddleLeft;
                col.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            }

            ddlProducts.Columns[0].IsVisible = false;
            //ddlProducts.Columns[3].IsVisible = false;
            ddlProducts.Columns[8].IsVisible = false;
            ddlProducts.Columns[1].HeaderText = "Name";
            ddlProducts.Columns[4].HeaderText = "R. Price";
            ddlProducts.Columns[5].HeaderText = "S. Price";
            ddlProducts.Columns[6].HeaderText = "Min. Price";
            ddlProducts.Columns[7].HeaderText = "W. Price";
            ddlProducts.Columns[1].Width = 200;
            ddlProducts.Columns[4].Width = 90;
            ddlProducts.Columns[5].Width = 90;
            ddlProducts.Columns[6].Width = 90;
            ddlProducts.Columns[7].Width = 90;

            if (Id > 0)
            {
                ddlProducts.SelectedValue = Id;
                //GetAccountDetails(Id);
            }

        }


        private void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetAccountDetails(Convert.ToInt32(ddlCustomer.SelectedValue));
            }
            catch { }
        }

        private void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetProductDetails(Convert.ToInt32(ddlProducts.SelectedValue));
                CalculateTotal();
            }
            catch { }
        }

        private void txtSalePrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
            CalculateDiscount();
            CalculateAdditional();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
            CalculateDiscount();
            CalculateAdditional();
        }

        public void LoadInvoiceItems()
        {
            dgItems.Columns.Clear();
            var obj = new InvoiceItemHelper().GetAllInvoicesItems(InvoiceID);
            var _Data = from a in obj
                        select new
                        {
                            a.InvoiceItemId,
                            Item = a.Title,
                            SPrice = Common.GetAsMoneyWithComma(a.SalePrice),
                            Qty = Common.GetAsMoneyWithComma(a.Qty),
                            Total = Common.GetAsMoneyWithComma(a.Total)
                        };

            dgItems.DataSource = _Data;
            //dgItems.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnEdit", "", 100, "InvoiceItemId", 30, 13)));
            dgItems.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnDelete", "", 100, "InvoiceItemId", 16, 16)));
            dgItems.TableElement.RowHeight = 20;
            dgItems.CellFormatting += new CellFormattingEventHandler(new GridHelper().GridCellFormatting);

            if (dgItems.Rows.Count > 0)
            {
                dgItems.Columns[0].IsVisible = false;
            }

            new GridHelper().SetGridHeaderAlignment(dgItems, ContentAlignment.MiddleLeft);
            //new GridHelper().SetButton(radButton1, "add.png");
            //new GridHelper().SetButton(radButton2, "back.png");
        }
        void SaveInvoice()
        
        {
            if (InvoiceID == 0)
                InvoiceID = new InvoiceHelper().SaveEditInvoice(new Model.Invoice
                {
                    AccountId = Convert.ToInt32(ddlCustomer.SelectedValue),
                    Date = dtInvoiceDate.Value,
                    Type = ddlInvoiceType.Text,
                    PaymentMethodId = 1,
                    Discount = txtDis.Text == "" ? 0 : Convert.ToDecimal(txtDis.Text),
                    DiscountAmount = _DiscountAmount,
                    Additional = txtAdditional.Text == "" ? 0 : Convert.ToDecimal(txtAdditional.Text),
                    AdditionalAmount = _AdditionalAmount

                }).InvoiceId;
            else
            {
                var obj = new InvoiceHelper().SaveEditInvoice(new Model.Invoice
                {
                    AccountId = Convert.ToInt32(ddlCustomer.SelectedValue),
                    Date = dtInvoiceDate.Value,
                    Type = ddlInvoiceType.Text,
                    PaymentMethodId = 1,
                    InvoiceId = InvoiceID,
                    Discount = txtDis.Text == "" ? 0 : Convert.ToDecimal(txtDis.Text),
                    DiscountAmount = _DiscountAmount,
                    Additional = txtAdditional.Text == "" ? 0 : Convert.ToDecimal(txtAdditional.Text),
                    AdditionalAmount = _AdditionalAmount
                });
            }

            if (SaveOnlyInvoice == false)
            {
                //add line item to invoice
                var item = new InvoiceItemHelper().SaveEditInvoiceItem(new Model.InvoiceItem
                {
                    CreatedOn = DateTime.Now,
                    InvoiceId = InvoiceID,
                    ProductId = Convert.ToInt32(ddlProducts.SelectedValue),
                    SalePrice = Convert.ToDecimal(txtSalePrice.Text),
                    Qty = Convert.ToDecimal(txtQty.Text),
                    StoreId = new StorewiseQuantityHelper().GetAllStoresQuantity(Convert.ToInt32(ddlProducts.SelectedValue)).Take(1).FirstOrDefault().StoreId,
                });
                new StorewiseQuantityHelper().ManageStoreQuantity(Convert.ToInt32(ddlProducts.SelectedValue), Convert.ToDecimal(txtQty.Text));
            }
            LoadInvoiceDetails();
            ResetForm();

        }

       
        void ResetForm()
        {
            txtSalePrice.Text = "";
            ddlProducts.SelectedIndex = 0;
            MinPrice = 0;
            txtQty.Text = "";
            txtTotalPrice.Text = "";
            ddlProducts.Focus();
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtSalePrice.Text == "")
            {
                MessageBox.Show("Enter Sale Price!");
                txtSalePrice.Focus();
                return;
            }

            if (txtQty.Text == "")
            {
                MessageBox.Show("Enter Sale Quantity!");
                txtQty.Focus();
                return;
            }
            else
            {
                if (Convert.ToDecimal(txtQty.Text) == 0)
                {
                    MessageBox.Show("Sale Quantity must be greater than 0");
                    txtQty.Focus();
                    return;
                }
                else
                {
                    if (Convert.ToDecimal(txtQty.Text) > _AQty)
                    {
                        MessageBox.Show("Entred Sale Quantity is greater than available quantity in stores.");
                        txtQty.Focus();
                        return;
                    }
                }
            }
            if (Convert.ToDecimal(txtSalePrice.Text) > 0)
            {
                if (Convert.ToDecimal(txtSalePrice.Text) < MinPrice)
                {
                    DialogResult dialogResult = MessageBox.Show("Sale Price is less than the Min Sale Price for this item, you want to continue?", "Sale Price", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SaveInvoice();
                       
                        LoadInvoiceItems();
                    }
                }
                else
                {
                    SaveInvoice();
                    LoadInvoiceItems();
                }
            }
            else
            {
                MessageBox.Show("Sale Price must be not 0.");
                txtSalePrice.Focus();
            }
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            AddEditInvoicePayment frm = new AddEditInvoicePayment(this, InvoiceID);
            frm.ShowDialog();
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

             
        }

        private void txtAdditional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

             
        }

        private void txtDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
        }

    
        private void txtDis_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscount();    
        }

        private void txtAdditional_TextChanged(object sender, EventArgs e)
        {
            CalculateAdditional();
        }

        private void radButtonSave_Click(object sender, EventArgs e)
        {
            SaveOnlyInvoice = true;
            SaveInvoice();
            LoadInvoiceDetails();
            SaveOnlyInvoice = false;
            MessageBox.Show("Invoice Changes Saved Successfully");
        }

        private void dgItems_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            int _Index = e.ColumnIndex;
            int _Id = Convert.ToInt32((sender as GridCommandCellElement).Value);

            //MessageBox.Show(_Index.ToString());
            
            if (_Index == 5)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var obj = new InvoiceItemHelper().DeleteInvoiceItem(_Id);
                    if (obj == true)
                    {
                        LoadInvoiceDetails();
                        LoadInvoiceItems(); 
                        LoadInvoicePayments();
                        MessageBox.Show("Item has been deleted from invoice.");
                    }
                    if (obj == false)
                    {
                        MessageBox.Show("An error occured while deleting item from invoice.");
                    }
                }

            }
        }
    }
}
