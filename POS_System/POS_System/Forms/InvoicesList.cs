using POS_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace POS_System.Forms
{
    public partial class InvoicesList : Telerik.WinControls.UI.RadForm
    {
        string InvoiceType;
        public InvoicesList(string invoiceType)
        {
            InitializeComponent();
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new System.Drawing.Size(w, h);
            InvoiceType = invoiceType;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadInvoices()
        {
            List<InvoiceV> obj = new List<InvoiceV>();
            dgInvoices.Columns.Clear();
            if (InvoiceType == "Sales Invoice")
                obj = new InvoiceHelper().GetAllInvoices();

            if (InvoiceType == "Sales Return Invoice")
                obj = new InvoiceHelper().GetAllSalesReturnInvoices();


            if (InvoiceType == "Purchase Order")
                obj = new InvoiceHelper().GetAllPurchaseInvoices();

            if (InvoiceType == "Purchase Return Invoice")
                obj = new InvoiceHelper().GetAllSalesReturnPurchaseInvoices();


            var _Data = from a in obj
                        select new
                        {
                            a.InvoiceId,
                            a.Date,
                            Account = a.Title,
                            a.Email,
                            a.CellNo,
                            Total = Common.GetAsMoneyWithComma(a.FinalTotal),
                            a.Paid,
                            a.PaymentMethod,
                            a.Type,
                            a.AccountType,
                        };
            dgInvoices.DataSource = _Data;
            dgInvoices.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnEdit", "", 100, "InvoiceId", 30, 13)));
            dgInvoices.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnDelete", "", 100, "InvoiceId", 16, 16)));
            dgInvoices.TableElement.RowHeight = 20;
            dgInvoices.CellFormatting += new CellFormattingEventHandler(new GridHelper().GridCellFormatting);

            if (dgInvoices.Rows.Count > 0)
            {
                dgInvoices.Columns[0].IsVisible = false;
                dgInvoices.Columns[1].HeaderText = "Name";
                dgInvoices.Columns[4].HeaderText = "Contact #";
                dgInvoices.Columns[5].HeaderText = "Total";
                dgInvoices.Columns[7].HeaderText = "Payment Method";
                dgInvoices.Columns[9].HeaderText = "Acc. Type";
            }

            new GridHelper().SetGridHeaderAlignment(dgInvoices, ContentAlignment.MiddleLeft);
            new GridHelper().SetButton(radButton1, "add.png");
            new GridHelper().SetButton(radButton2, "back.png");
        }

        private void InvoicesList_Load(object sender, EventArgs e)
        {

            if (InvoiceType == "Sales Invoice")
            {
                radButton1.Text = "Add Sales Invoice";
                lblTitle.Text = "Sales Invoices";
            }

            if (InvoiceType == "Sales Return Invoice")
            {
                radButton1.Text = "Add Return Invoice";
                lblTitle.Text = "Sales Return Invoices";
            }


            if (InvoiceType == "Purchase Order")
            {
                radButton1.Text = "Add PO";
                lblTitle.Text = "Purchase Orders";
            }

            if (InvoiceType == "Purchase Return Invoice")
            {
                radButton1.Text = "Add Return PO";
                lblTitle.Text = "Purchase Orders Return Invoices";
            }


            this.Text = lblTitle.Text;
            this.WindowState = FormWindowState.Maximized;
            LoadInvoices();
        }

        private void dgInvoices_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            int _Index = e.ColumnIndex;
            int _Id = Convert.ToInt32((sender as GridCommandCellElement).Value);

            //MessageBox.Show(_Index.ToString());
            if (_Index == 10)
            {

                if (InvoiceType != "Purchase Order")
                {
                    AddEditInvoiceForm frm1 = new AddEditInvoiceForm(this, _Id, InvoiceType);
                    frm1.MdiParent = this.MdiParent;
                    frm1.Show();
                }
                else
                {
                    AddEditPurchaseForm frm = new AddEditPurchaseForm(this, _Id, InvoiceType);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }

                //AddEditInvoiceForm frm = new AddEditInvoiceForm(this, _Id, InvoiceType);
                //frm.MdiParent = this.MdiParent;
                //frm.Show();

            }

            if (_Index == 11)
            {
                //DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (dialogResult == DialogResult.Yes)
                //{
                //    var obj = new StoreHelper().DeleteStore(_Id);
                //    if (obj == true)
                //    {
                //        LoadInvoices();
                //        MessageBox.Show("Invoice has been deleted.");
                //    }
                //    if (obj == false)
                //    {
                //        MessageBox.Show("An error occured while deleting Invoice.");
                //    }
                //}

            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            if (InvoiceType.Contains("Purchase"))
            {
                AddEditPurchaseForm frm = new AddEditPurchaseForm(this, 0, InvoiceType);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else
            {
                AddEditInvoiceForm frm = new AddEditInvoiceForm(this, 0, InvoiceType);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            

        }
    }
}
