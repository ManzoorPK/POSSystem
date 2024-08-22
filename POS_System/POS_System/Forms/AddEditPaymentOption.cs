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
    public partial class AddEditPaymentOption : Telerik.WinControls.UI.RadForm
    {
        PaymentOptionsList PL;
        int OptionId = 0;
        public AddEditPaymentOption(PaymentOptionsList _PL, int _OptionId)
        {
            InitializeComponent();
            PL = _PL;
            OptionId = _OptionId;
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void radButtonSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Enter Payment Option Title");
                txtTitle.Focus();
                return;
            }

            var obj = new PaymentOptionHelper().SaveEditPaymentOption(new Model.PaymentOption
            {
                PaymentOptionsId = OptionId,
                Title = txtTitle.Text,
                IsActive = chkActive.Checked,
            });

            if (obj)
            {
                if (OptionId == 0)
                {
                    txtTitle.Text = "";
                    chkActive.Checked = false;  
                }
                else
                    this.Close();

                if (PL != null)
                    PL.LoadPaymentOptions();


                MessageBox.Show("Payment Option changes saved successfully.");
            }
        }
        void FillList()
        {
            if (OptionId > 0)
                this.Text = "Update Payment Option";
            else
                this.Text = "Add new Payment Option";

            lblTitle.Text = this.Text;
          
            new GridHelper().SetButton(radButtonSave, "save.png", 15, 15);
            new GridHelper().SetButton(radButtonCancel, "back.png", 15, 15);
            
        }
        private void AddEditPaymentOption_Load(object sender, EventArgs e)
        {
            FillList();

            if (OptionId > 0)
                GetPaymentOption();
            else
            {
                txtTitle.Text = "";
                chkActive.Checked = false;
                
            }
        }

        void GetPaymentOption()
        {
            var obj = new PaymentOptionHelper().GetPaymentionOptionById(OptionId); 
            txtTitle.Text = obj.Title;
            chkActive.Checked = Convert.ToBoolean( obj.IsActive);
        }
    }
}
