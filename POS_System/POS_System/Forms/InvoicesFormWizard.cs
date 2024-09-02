using POS_System.Model;
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
using Telerik.WinControls.UI;

namespace POS_System.Forms
{
    public partial class InvoicesFormWizard : Telerik.WinControls.UI.RadForm
    {
        AddEditInvoiceForm AI;
        AddEditPurchaseForm AF;
        public InvoicesFormWizard(AddEditInvoiceForm ai)
        {
            InitializeComponent();
            AI = ai;
        }
        public InvoicesFormWizard(AddEditPurchaseForm af)
        {
            InitializeComponent();
            AF = af;
        }
        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void LoadItems(int Id)
        {

            var lst = new InvoiceItemHelper().GetAllInvoicesItems(Id);
            if (lst.Count > 0)
            {
                dgInventories.Rows.Clear();
                foreach (var item in lst)
                {
                    dgInventories.Rows.Add(null, item.InvoiceItemId, item.Title, Common.GetAsMoneyWithComma(item.SalePrice),
                                            Common.GetAsMoneyWithComma(item.Qty), Common.GetAsMoneyWithComma(item.Total));
                }
            }

            new GridHelper().SetGridHeaderAlignment(dgInventories, ContentAlignment.MiddleLeft);
        }
        void LoadInvoices()
        {
            List<InvoiceV> _Data = null;

            if (AF == null)
                _Data = new InvoiceHelper().GetAllInvoices();
            else
                _Data = new InvoiceHelper().GetAllPurchaseInvoices();

            _Data.Insert(0, new Model.InvoiceV { Title = "" });

            var obj = (from a in _Data
                       select new
                       {
                           a.InvoiceId,
                           Date = Convert.ToDateTime(a.Date).ToString("dd-MM-yyyy"),
                           a.Title,
                           Code = a.AccountCode,
                           a.Type,
                           Total = Common.GetAsMoneyWithComma(a.FinalTotal),
                           Searcho = a.InvoiceId.ToString() + " " + a.Title + " " + a.AccountCode
                          
                       }).ToList();

            ddlInvoices.DataSource = obj;

            this.ddlInvoices.AutoFilter = true;
            this.ddlInvoices.DisplayMember = "Title";
            this.ddlInvoices.ValueMember = "InvoiceId";
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = "Searcho";
            filter.Operator = FilterOperator.Contains;
            this.ddlInvoices.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);

            foreach (var col in this.ddlInvoices.Columns)
            {
                col.Width = 120;
                col.TextAlignment = ContentAlignment.MiddleLeft;
                col.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            }

            ddlInvoices.Columns[6].IsVisible = false;
            ddlInvoices.Columns[0].HeaderText = "Inv #";
            ddlInvoices.Columns[3].HeaderText = "Title";
        }

        private void InvoicesFormWizard_Load(object sender, EventArgs e)
        {
            LoadInvoices();
        }

        private void ddlInvoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadItems(Convert.ToInt32(ddlInvoices.SelectedValue));
            }
            catch { }
        }

        private void btnReturnItems_Click(object sender, EventArgs e)
        {
            int Count = 0;
            List<int> ids = new List<int>();
            foreach (GridViewRowInfo item in dgInventories.Rows.ToList())
            {
                if (item.Cells[0].Value != null)
                {
                    if (item.Cells[0].Value.Equals(true))
                    {
                        //MessageBox.Show(item.Cells[1].Value.ToString());
                        ids.Add(Convert.ToInt32(item.Cells[1].Value));
                        Count++;
                    }
                }
            }

            if (Count == 0)
            {
                MessageBox.Show("Select any item to return");
            }
            else
            {
                if (AI != null)
                {
                    AI.GetItemsToReturn(ids);
                    this.Close();
                }
                if (AF != null)
                {
                    AF.GetItemsToReturn(ids);
                    this.Close();
                }

            }
        }
    }
}