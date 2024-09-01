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
    public partial class AddEditAccount : Telerik.WinControls.UI.RadForm
    {
        AddEditInvoiceForm AI;
        AddEditPurchaseForm AF;
        int AccountId = 0;
        string form;
        public AddEditAccount(AddEditInvoiceForm aI, int accountId, string form)
        {
            InitializeComponent();
            AI = aI;
            AccountId = accountId;
            this.form = form;
        }
        public AddEditAccount(AddEditPurchaseForm af, int accountId, string form)
        {
            InitializeComponent();
            AF = af;    
            AccountId = accountId;
            this.form = form;
        }
        void FillList()
        {
            if (AccountId > 0)
                this.Text = "Update Account";
            else
                this.Text = "Add new Account";

            lblTitle.Text = this.Text;

            new GridHelper().SetButton(radButtonSave, "save.png", 15, 15);
            new GridHelper().SetButton(radButtonCancel, "back.png", 15, 15);

        }
        void GetAccount()
        {

        }
        void ResetForm()
        {
            txtAddress.Text = "";
            txtCode.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtTitle.Text = "";
            rdCustomer.IsChecked = true;
        }
        private void AddEditAccount_Load(object sender, EventArgs e)
        {
            FillList();

            if (AccountId > 0)
                GetAccount();
            else
                ResetForm();
        }

        string GetType()
        {
            string type = "Customer";
            if (rdCustomer.IsChecked == true)
                type = "Customer";
            if (rdSupplier.IsChecked == true)
                type = "Supplier";
            if (rdSalesman.IsChecked == true)
                type = "Salesman";
            if (rdOther.IsChecked == true)
                type = "Others";

            return type;
        }
        private void radButtonSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Focus();   
                MessageBox.Show("Enter Account Title");
            }

            var obj = new AccountHelper().SaveEditAccount(new Account
            {
                Title = txtTitle.Text,
                AccountCode = txtCode.Text,
                CellNo = txtContact.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                Type = GetType(),
                CreatedOn = DateTime.Now,
            });

            if (obj != null)
            {
                if (AccountId == 0)
                {
                    ResetForm();    
                }
                else
                    this.Close();

                if (AI != null)
                    AI.LoadCustomers(obj.AccountId);

                if (AF != null)
                    AF.LoadCustomers(obj.AccountId);

                if (form == "Invoice")
                    this.Close();
                //MessageBox.Show("Store changes saved successfully.");
            }

            if (obj == null)
                MessageBox.Show("Account changes not saved.");
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
