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
    public partial class StoreList : Telerik.WinControls.UI.RadForm
    {
        public StoreList()
        {
            InitializeComponent();
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new System.Drawing.Size(w, h);
        }

        private void StoreList_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "My Stores";
            radButton1.Text = "Add Store";
            this.Text = lblTitle.Text;
            this.WindowState = FormWindowState.Maximized;
            LoadMyStores();
        }
        public void LoadMyStores()
        {
            dgInventories.Columns.Clear();
            var obj = new StoreHelper().GetAllStores();
            var _Data = from a in obj
                        select new
                        {
                            a.StoreId,
                            a.Store1
                        };


            dgInventories.DataSource = _Data;
            dgInventories.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnEdit", "", 100, "StoreId", 30, 13)));
            dgInventories.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnDelete", "", 100, "StoreId", 16, 16)));
            dgInventories.TableElement.RowHeight = 20;
            dgInventories.CellFormatting += new CellFormattingEventHandler(new GridHelper().GridCellFormatting);

            if (dgInventories.Rows.Count > 0)
            {
                dgInventories.Columns[0].IsVisible = false;
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
            AddEditStore frm = new AddEditStore(this, 0);
            frm.ShowDialog();   
        }

        private void dgInventories_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            int _Index = e.ColumnIndex;
            int _Id = Convert.ToInt32((sender as GridCommandCellElement).Value);

            //MessageBox.Show(_Index.ToString());
            if (_Index == 2)
            {
                AddEditStore frm = new AddEditStore(this, _Id);
                frm.ShowDialog();
            }

            if (_Index == 3)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var obj = new  StoreHelper().DeleteStore(_Id);
                    if (obj == true)
                    {
                        LoadMyStores();
                        MessageBox.Show("Store has been deleted.");
                    }
                    if (obj == false)
                    {
                        MessageBox.Show("An error occured while deleting Store.");
                    }
                }

            }
        }
    }
}
