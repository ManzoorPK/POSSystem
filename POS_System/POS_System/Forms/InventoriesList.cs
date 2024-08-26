using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace POS_System
{
    public partial class InventoriesList : Telerik.WinControls.UI.RadForm
    {
        private string type = "";
        public InventoriesList(string _type)
        {
            InitializeComponent();
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new System.Drawing.Size(w, h);
            type = _type;
        }
        private void InventoriesList_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "All Products";
            radButton1.Text = "Add Product";
            this.Text = lblTitle.Text;
            this.WindowState = FormWindowState.Maximized;
            LoadInventories();
            LoadCategories();
        }
        public void LoadCategories()
        {
            ddlCategory.Items.Clear();
            ddlCategory.DataSource = new CategoryHelper().GetAllCategories(true);
            ddlCategory.DisplayMember = "Category1";
            ddlCategory.ValueMember = "CategoryId";
        }
        public void LoadInventories(int CategoryId = -1)
        {
            //BusinessHelper.BusinessId = (ddlType.SelectedIndex == 0 ? 1 : 2);
            dgInventories.Columns.Clear();
            
            if (CategoryId == -1)
            {
                var obj = new ProductHelper().GetAllProducts();
                var _Data = from a in obj
                            select new
                            {
                                a.ProductId,
                                a.Title,
                                Category = new CategoryHelper().GetCategoryById(a.CategoryId == null ? 0 : Convert.ToInt32(a.CategoryId)),
                                SPrice = Common.GetAsMoneyWithComma(a.SalePrice),
                                MSPrice = Common.GetAsMoneyWithComma(a.MinSalePrice),
                                qty = Common.GetAsMoneyWithComma(a.TotalQuantity),
                                a.Barcode,
                                a.Code1,
                                a.Code2,
                                
                            };


                dgInventories.DataSource = _Data;
                dgInventories.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnEdit", "", 100, "ProductId", 30, 13)));
                //dgInventories.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnDelete", "", 100, "InventoryId", 16, 16)));
            }
            else
            {
                var obj = new ProductHelper().GetAllProducts().Where(x=> x.CategoryId == Convert.ToInt32(ddlCategory.SelectedValue)).ToList();
                var _Data = from a in obj
                            select new
                            {
                                a.ProductId,
                                a.Title,
                                Category = new CategoryHelper().GetCategoryById(a.CategoryId == null ? 0 : Convert.ToInt32(a.CategoryId)),
                                SPrice = Common.GetAsMoneyWithComma(a.SalePrice),
                                MSPrice = Common.GetAsMoneyWithComma(a.MinSalePrice),
                                qty = Common.GetAsMoneyWithComma( a.TotalQuantity),
                                a.Barcode,
                                a.Code1,
                                a.Code2
                            };


                dgInventories.DataSource = _Data;
                dgInventories.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnEdit", "", 100, "ProductId", 30, 13)));
                //dgInventories.Columns.Add(new GridHelper().AddCommandButton(new CommandButton("btnDelete", "", 100, "InventoryId", 16, 16)));
            }
            dgInventories.TableElement.RowHeight = 20;
            dgInventories.CellFormatting += new CellFormattingEventHandler(new GridHelper().GridCellFormatting);

            if (dgInventories.Rows.Count > 0)
            {
                dgInventories.Columns[0].IsVisible = true;
                dgInventories.Columns[3].HeaderText = "Sale Price";
                dgInventories.Columns[4].HeaderText = "Min. Sale Price";
                dgInventories.Columns[5].HeaderText = "Total Qty";
                 
            }

            new GridHelper().SetGridHeaderAlignment(dgInventories, ContentAlignment.MiddleLeft);
            new GridHelper().SetButton(radButton1, "add.png");
            new GridHelper().SetButton(radButton2, "back.png");

            //var summaryItem1 = new GridViewSummaryItem("ProductId", "{0}", GridAggregateFunction.Sum);
            //var summaryRow1 = new GridViewSummaryRowItem(new[] { summaryItem1 });
            //dgInventories.SummaryRowsBottom.Add(summaryRow1);
            
        }

        private void dgInventories_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            int _Index = e.ColumnIndex;
            int _Id = Convert.ToInt32((sender as GridCommandCellElement).Value);

            //MessageBox.Show(_Index.ToString());
            if (_Index == 9)
            {
                AddEditInventory frm = new AddEditInventory(this, _Id);
                frm.ShowDialog();
            }

            //if (_Index == 8)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        //var obj = new InventoryHelper().DeleteInventory(_Id);
            //        //if (obj == EntryStatus.Deleted)
            //        //{
            //        //    LoadInventories();
            //        //    MessageBox.Show("Item has been deleted.");
            //        //}
            //        //if (obj == EntryStatus.Error)
            //        //{
            //        //    MessageBox.Show("An error occured while deleting Item.");
            //        //}
            //    }

            //}

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            AddEditInventory frm = new AddEditInventory(this, 0);
            frm.ShowDialog();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void PrintReport()
        {

            //var lst = new SupplierHelper().GetAllSuppliers();
            //int _Balance = 0;
            //foreach (var item in lst)
            //{
            //    _Balance += Decimal.ToInt32(Convert.ToDecimal(item.OldBalance));
            //}

            //ReportDto report = new ReportDto();
            //report.POReport = new POReport
            //{
            //    Date = DateTime.Now.ToString("dd/MM/yyyy"),
            //    Total = Common.GetAsMoneyWithComma(0).ToString()
            //};

            //ReportViwerForm frm = new ReportViwerForm("Suppliers", report);
            //frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            //PrintReportHelper.PrintReport(report, "Products");
        }
        private void radButtonPrint_Click(object sender, EventArgs e)
        {
            PrintReport();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.P))
            {
                PrintReport();
                return true;
            }

            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ddlType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }
        void GetStorewiseQuantity(int InventoryID)
        {
            dgStores.Rows.Clear();
            var obj = new StorewiseQuantityHelper().GetAllStoresQuantity(InventoryID);
           
            foreach (var item in obj)
            {
                dgStores.Rows.Add(item.StoreQuantityId, item.Store, item.WarehousId == null ? "" : (item.WarehousId == 0 ? "" : new WarehouseHelper().GetWarehouseById(Convert.ToInt32(item.WarehousId)).Warehouse1),  item.Quantity, item.StoreId);
            }

            dgStores.TableElement.RowHeight = 30;
            dgStores.CellFormatting += new CellFormattingEventHandler(new GridHelper().GridCellFormatting);

            if (dgStores.Rows.Count > 0)
            {
                dgStores.Columns[0].IsVisible = false;
                dgStores.Columns[4].IsVisible = false;
                dgStores.Columns[2].ReadOnly = false;
                dgStores.Columns[3].ReadOnly = false;

            }
            new GridHelper().SetGridHeaderAlignment(dgStores, ContentAlignment.MiddleLeft);
        }
        private void dgInventories_SelectionChanging(object sender, GridViewSelectionCancelEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(dgInventories.CurrentRow.Cells[0].Value);
                //MessageBox.Show(Id.ToString());
                GetStorewiseQuantity(Id);
            }
            catch { }
        }

        private void ddlCategory_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                LoadInventories(Convert.ToInt32(ddlCategory.SelectedValue));
            }
            catch { }
        }
    }
}
