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
    public partial class WarehouseList : Telerik.WinControls.UI.RadForm
    {
        public WarehouseList()
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

        private void WarehouseList_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Warehouses";
            radButton1.Text = "Add Warehouse";
            this.Text = lblTitle.Text;
            this.WindowState = FormWindowState.Maximized;
            LoadWarehouses();
        }
        public void LoadWarehouses()
        {
            dg.Columns.Clear();
            var obj = new WarehouseHelper().GetAllWarehoues();
            
            dg.DataSource = obj;
            dg.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnEdit", "", 100, "WarehouseId", 30, 13)));
            dg.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnDelete", "", 100, "WarehouseId", 16, 16)));
            dg.TableElement.RowHeight = 20;
            dg.CellFormatting += new CellFormattingEventHandler(new GridHelper().GridCellFormatting);

            if (dg.Rows.Count > 0)
            {
                dg.Columns[0].IsVisible = false;
                dg.Columns[5].IsVisible = false;
                dg.Columns[1].HeaderText = "Name";

            }

            new GridHelper().SetGridHeaderAlignment(dg, ContentAlignment.MiddleLeft);
            new GridHelper().SetButton(radButton1, "add.png");
            new GridHelper().SetButton(radButton2, "back.png");

        }

        private void dg_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            int _Index = e.ColumnIndex;
            int _Id = Convert.ToInt32((sender as GridCommandCellElement).Value);

            //MessageBox.Show(_Index.ToString());
            if (_Index == 6)
            {
                AddEditWarehouse frm = new AddEditWarehouse(this, _Id);
                frm.ShowDialog();
            }

            if (_Index == 7)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var obj = new WarehouseHelper().DeleteWarehouse(_Id);
                    if (obj == true)
                    {
                        LoadWarehouses();
                        MessageBox.Show("Warehouse has been deleted.");
                    }
                    if (obj == false)
                    {
                        MessageBox.Show("An error occured while deleting Store.");
                    }
                }

            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            AddEditWarehouse frm = new AddEditWarehouse(this, 0);
            frm.ShowDialog();
        }
    }
}
