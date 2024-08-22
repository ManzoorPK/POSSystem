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
    public partial class AddEditStore : Telerik.WinControls.UI.RadForm
    {
        StoreList _storeList;
        int StoreId = 0;
        public AddEditStore(StoreList SL, int _StoreId)
        {
            InitializeComponent();
            _storeList = SL;  
            StoreId = _StoreId;
        }

        private void AddEditStore_Load(object sender, EventArgs e)
        {
            if (StoreId > 0)
            {
                var obj = new StoreHelper().GetStoreById(StoreId);
                txtTitle.Text = obj.Store1;
            }

            FillList();
        }
        void FillList()
        {
            if (StoreId > 0)
                this.Text = "Update Store";
            else
                this.Text = "Add new Store";


            lblTitle.Text = this.Text;


            new GridHelper().SetButton(radButtonSave, "save.png", 15, 15);
            new GridHelper().SetButton(radButtonCancel, "back.png", 15, 15);
             
        }
        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Enter Store Name!");
                txtTitle.Focus();
                return;
            }
            var obj = new StoreHelper().SaveEditStore(new Model.Store
            {
                StoreId = StoreId,
                Store1 = txtTitle.Text,
            });

            if (obj == true)
            {
                if (StoreId == 0)
                {
                    txtTitle.Text = "";
                    StoreId = 0;
                }
                else
                    this.Close();

                if (_storeList != null)
                    _storeList.LoadMyStores();

                MessageBox.Show("Store changes saved successfully.");
            }

            if (obj == false)
                MessageBox.Show("Store changes not saved.");

        }
    }
}
