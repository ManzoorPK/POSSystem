using POS_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace POS_System.Forms
{
    public partial class AddEditInvoicePayment : Telerik.WinControls.UI.RadForm
    {
        AddEditInvoiceForm AI;
        int InvoiceId = 0;
        decimal _Total = 0;
        decimal _Paid = 0;
        decimal _Balance = 0;
        public AddEditInvoicePayment(AddEditInvoiceForm aI, int invoiceId)
        {
            InitializeComponent();
            dtPaymentDate.Value = DateTime.Now;
            AI = aI;
            InvoiceId = invoiceId;
        }
        void LoadInvoiceDetails()
        {
            ddlPaymentMethod.DataSource = new PaymentOptionHelper().GetAllPaymentOptions();
            ddlPaymentMethod.DisplayMember = "Title";
            ddlPaymentMethod.ValueMember = "PaymentOptionsId";

            var obj = new InvoiceHelper().GetInvoiceById(InvoiceId);
            if (obj != null)
            {
                _Total = Convert.ToDecimal( obj.TotalPayment);
                _Paid = Convert.ToDecimal( obj.Paid );
                _Balance = Convert.ToDecimal( obj.Balance );    

                txtTotal.Text = Common.GetAsMoneyWithComma(obj.TotalPayment);
                txtPaid.Text = Common.GetAsMoneyWithComma(obj.Paid);
                txtBalance.Text = Common.GetAsMoneyWithComma(obj.Balance);
            }
        }

        private void radButtonSave_Click(object sender, EventArgs e)
        {
            if (txtPayNow.Text == "")
            {
                MessageBox.Show("Enter Amount To Pay");
                txtPayNow.Focus();
                return;
            }

            if (Convert.ToDecimal(txtPayNow.Text) == 0)
            {
                MessageBox.Show("Amount should be greater then 0");
                txtPayNow.Focus();
                return;
            }

            //if (Convert.ToDecimal(txtPayNow.Text)> _Balance)
            //{
            //    MessageBox.Show("Amount is greator than the total payables, please check your entred amount.");
            //    txtPayNow.Focus();
            //    return;
            //}

            var obj = new InvoicePaymentHelper().SaveEditInvoicePayment(new InvoicePayment
            {
                 Date = dtPaymentDate.Value,
                 PaymentMethodId = Convert.ToInt32( ddlPaymentMethod.SelectedValue),
                 Remarks = txtRemarks.Text,
                 Total = _Balance,
                 Paid = Convert.ToDecimal(txtPayNow.Text),
                 InvoiceId = InvoiceId,
                
            });

            if (obj)
            {
                txtRemarks.Text = "";
                dtPaymentDate.Value = DateTime.Now;
                txtPayNow.Text = "";
                txtPayNow.Focus();
                LoadInvoiceDetails();
                AI.LoadInvoiceDetails();
                MessageBox.Show("Payment has been made successfully!");
            }
            else
            {
                MessageBox.Show("An error occured while processing payment!");
            }
        }

        private void AddEditInvoicePayment_Load(object sender, EventArgs e)
        {
            LoadInvoiceDetails();
            new GridHelper().SetButton(radButtonSave, "save.png", 15, 15);
            new GridHelper().SetButton(radButtonCancel, "back.png", 15, 15);
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
