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
    public partial class AddEditWarehouse : Telerik.WinControls.UI.RadForm
    {
        WarehouseList WL;
        int WarehouseId = 0;
        public AddEditWarehouse(WarehouseList _WL, int _WarehouseId)
        {
            InitializeComponent();
            WL = _WL;
            WarehouseId = _WarehouseId; 
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        void FillList()
        {
            if (WarehouseId > 0)
                this.Text = "Update Warehouse";
            else
                this.Text = "Add new Warehouse";


            lblTitle.Text = this.Text;


            new GridHelper().SetButton(radButtonSave, "save.png", 15, 15);
            new GridHelper().SetButton(radButtonCancel, "back.png", 15, 15);

        }

        private void AddEditWarehouse_Load(object sender, EventArgs e)
        {
            if (WarehouseId > 0)
            {
                var obj = new WarehouseHelper().GetWarehouseById(WarehouseId);
                txtWarehouse.Text = obj.Warehouse1;
                txtContact.Text = obj.Phone;
                txtEmail.Text = obj.Email;  
                txtAddress.Text = obj.Address;  
            }

            FillList();
        }

        private void radButtonSave_Click(object sender, EventArgs e)
        {
            if (txtWarehouse.Text == "")
            {
                MessageBox.Show("Enter Warehouse Name!");
                txtWarehouse.Focus();
                return;
            }

            var obj = new WarehouseHelper().SaveEditHelper(new Warehouse
            {
                WarehouseId = WarehouseId,
                Warehouse1 = txtWarehouse.Text,
                Phone = txtContact.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
            });

            if (obj == true)
            {
                if (WarehouseId == 0)
                {
                    txtWarehouse.Text = "";
                    txtContact.Text = "";
                    txtEmail.Text = "";
                    txtAddress.Text = "";
                }
                else
                    this.Close();

                if (WL != null)
                    WL.LoadWarehouses();

                MessageBox.Show("Warehouse changes saved successfully.");
            }

            if (obj == false)
                MessageBox.Show("Warehouse changes not saved.");
        }
    }
}
