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
    public partial class ReceiptList : Telerik.WinControls.UI.RadForm
    {
        public ReceiptList()
        {
            InitializeComponent();
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new System.Drawing.Size(w, h);
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void ReceiptList_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Payment Receipts";
            radButton1.Text = "Add new Receipt";
            this.Text = lblTitle.Text;
            this.WindowState = FormWindowState.Maximized;
            LoadPayments(); 
        }

        public void LoadPayments()
        {
            dgReceipts.Columns.Clear();
            var obj = new ReceiptHelper().GetAllReceipts();
            var _Data = from a in obj
                        select new
                        {
                            a.ReceiptId,
                            Date = Convert.ToDateTime( a.Date).ToString("dd-MM-yyyy"),
                            Amount = Common.GetAsMoneyWithComma(a.Amount),
                            Account = a.Title,
                            a.IncomeType,
                            a.PaymentMethod,
                            a.Type
                        };


            dgReceipts.DataSource = _Data;
            dgReceipts.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnEdit", "", 100, "StoreId", 30, 13)));
            dgReceipts.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnDelete", "", 100, "StoreId", 16, 16)));
            dgReceipts.TableElement.RowHeight = 20;
            dgReceipts.CellFormatting += new CellFormattingEventHandler(new GridHelper().GridCellFormatting);

            if (dgReceipts.Rows.Count > 0)
            {
                dgReceipts.Columns[0].IsVisible = false;
                dgReceipts.Columns[5].HeaderText = "Payment Method";
            }

            new GridHelper().SetGridHeaderAlignment(dgReceipts, ContentAlignment.MiddleLeft);
            new GridHelper().SetButton(radButton1, "add.png");
            new GridHelper().SetButton(radButton2, "back.png");

        }
    }
}
