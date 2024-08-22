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
    public partial class PaymentOptionsList : Telerik.WinControls.UI.RadForm
    {
        public PaymentOptionsList()
        {
            InitializeComponent();
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new System.Drawing.Size(w, h);
        }

        private void PaymentOptionsList_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Payment Options";
            radButton1.Text = "Add Payment Option";
            this.Text = lblTitle.Text;
            this.WindowState = FormWindowState.Maximized;
            LoadPaymentOptions();
        }

        public void LoadPaymentOptions()
        {
            dgInventories.Columns.Clear();
            var obj = new PaymentOptionHelper().GetAllPaymentOptions();
           
            dgInventories.DataSource = obj;
            dgInventories.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnEdit", "", 100, "PaymentOptionsId", 30, 13)));
            dgInventories.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnDelete", "", 100, "PaymentOptionsId", 16, 16)));
            dgInventories.TableElement.RowHeight = 20;
            dgInventories.CellFormatting += new CellFormattingEventHandler(new GridHelper().GridCellFormatting);

            dgInventories.Columns[0].IsVisible = false;

            if (dgInventories.Rows.Count > 0)
            {
               
            }

            new GridHelper().SetGridHeaderAlignment(dgInventories, ContentAlignment.MiddleLeft);
            new GridHelper().SetButton(radButton1, "add.png");
            new GridHelper().SetButton(radButton2, "back.png");
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            AddEditPaymentOption frm = new AddEditPaymentOption(this, 0);
            frm.ShowDialog();   
        }

        private void dgInventories_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            int _Index = e.ColumnIndex;
            int _Id = Convert.ToInt32((sender as GridCommandCellElement).Value);

            //MessageBox.Show(_Index.ToString());
            if (_Index == 3)
            {
                AddEditPaymentOption frm = new AddEditPaymentOption(this, _Id);
                frm.ShowDialog();
            }

            if (_Index == 4)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var obj = new PaymentOptionHelper().DeletePaymentOption(_Id);
                    if (obj == true)
                    {
                        LoadPaymentOptions();
                        MessageBox.Show("Payment Option has been deleted.");
                    }
                    if (obj == false)
                    {
                        MessageBox.Show("An error occured while deleting Payment Option.");
                    }
                }

            }
        }
    }
}
