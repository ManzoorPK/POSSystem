using POS_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace POS_System
{
    public partial class DashboardForm : Telerik.WinControls.UI.RadForm
    {
        public DashboardForm()
        {
            InitializeComponent();

            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lblDate.Text = "Today Is " + DateTime.Now.Date.ToString("dd-MM-yyyy");

            new GridHelper().SetButton(btnProducts, "products.png", 50, 50);
            new GridHelper().SetButton(btnAccounts, "Customers.png", 50, 50);
            new GridHelper().SetButton(btnCashbook, "returninvoice.png", 50, 50);
            new GridHelper().SetButton(btnInvoices, "invoices.png", 50, 50);
            new GridHelper().SetButton(btnrReports, "attach.png", 50, 50);
            new GridHelper().SetButton(btnSales, "payment.png", 50, 50);
            new GridHelper().SetButton(btnPurchase, "addproduct.png", 50, 50);
            new GridHelper().SetButton(btnPayments, "payment.png", 50, 50);

        }

        private void DashboardForm_Activated(object sender, EventArgs e)
        {

        }

        private void DashboardForm_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            InventoriesList frm = new InventoriesList("");
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            AddEditInvoiceForm frm = new AddEditInvoiceForm("Sales Invoice");
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            AddEditPurchaseForm frm = new AddEditPurchaseForm();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
