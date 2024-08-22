
using POS_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace POS_System
{
    public partial class AddEditInventory : Telerik.WinControls.UI.RadForm
    {
        private string pictureFileName = "";
        private byte[] pictureData = null;
        private string type = "";
        private int InventoryID = 0;
        private InventoriesList IL;
        private MDIParent _MDIParent;
        public AddEditInventory(InventoriesList _IL, int _InventoryID, MDIParent mDIParent = null)
        {
            InitializeComponent();
            IL = _IL;
            InventoryID = _InventoryID;
            _MDIParent = mDIParent;
        }

        public AddEditInventory()
        {
            InitializeComponent();

        }

        private void AddEditInventory_Load(object sender, EventArgs e)
        {
            FillList();

            if (InventoryID > 0)
                GetInventory();
            else
                ResetForm();

            //GetStorewiseQuantity();
        }
        void ResetForm()
        {
            txtBarcode.Text = "";
            txtCode1.Text = "";
            txtCode2.Text = "";
            txtDescription.Text = "";
            txtTitle.Text = "";
            chkActive.Checked = false;
            chkExpire.Checked = false;
            ItemPic.Image = null;
            pictureData = null;
            txtTitle.Focus();
            ddlCategory.Text = "";
        }

        void GetStorewiseQuantity()
        {
            dgStores.Rows.Clear();
            var obj = new StorewiseQuantityHelper().GetAllStoresQuantity(InventoryID);
            var _Data = from a in obj
                        select new
                        {
                            a.StoreQuantityId,
                            Store = a.Store,
                            Qty = Common.GetAsMoneyWithComma(a.Quantity)
                        };

            foreach (var item in obj)
            {
                dgStores.Rows.Add(item.StoreQuantityId, item.Store, item.Quantity, item.StoreId);
            }

            dgStores.TableElement.RowHeight = 25;
            dgStores.CellFormatting += new CellFormattingEventHandler(new GridHelper().GridCellFormatting);

            if (dgStores.Rows.Count > 0)
            {
                dgStores.Columns[0].IsVisible = false;
                dgStores.Columns[3].IsVisible = false;
                dgStores.Columns[2].ReadOnly = false;

                dgStores.Columns[1].ReadOnly = true;

            }
            new GridHelper().SetGridHeaderAlignment(dgStores, ContentAlignment.MiddleLeft);
        }
        void GetInventory()
        {
            var obj = new ProductHelper().GetProductById(InventoryID);

            txtTitle.Text = obj.Title;
            txtSalePrice.Text = obj.SalePrice.ToString();
            txtMinSalePrice.Text = obj.MinSalePrice.ToString();
            txtDescription.Text = obj.Descrioption;
            txtBarcode.Text = obj.Barcode;
            txtCode1.Text = obj.Code1;
            txtCode2.Text = obj.Code2;
            chkActive.Checked = (obj.IsActive == true ? true : false);
            chkExpire.Checked = (obj.IsExpirable == true ? true : false);
            txtRPrice.Text = obj.RetailPrice == null ? "" : obj.RetailPrice.ToString();
            txtWPrice.Text = obj.WholeSalePrice == null ? "" : obj.WholeSalePrice.ToString();

            if (obj.CategoryId != null)
            {
                ddlCategory.SelectedValue = obj.CategoryId;
            }
            else
                ddlCategory.Text = "";

            if (!DBNull.Value.Equals(obj.Picture))
            {
                if (obj.Picture != null)
                {
                    pictureData = obj.Picture;
                    ItemPic.Image = System.Drawing.Image.FromStream(new MemoryStream(pictureData));
                }
            }

            GetStorewiseQuantity();
        }
        void FillList()
        {
            if (InventoryID > 0)
                this.Text = "Update Product";
            else
                this.Text = "Add new Product";


            lblTitle.Text = this.Text;

            LoadCategories();
            new GridHelper().SetButton(radButtonSave, "save.png", 15, 15);
            new GridHelper().SetButton(radButtonCancel, "back.png", 15, 15);
            new GridHelper().SetButton(radButtonUpload, "upload.png", 15, 15);
        }

        private void radButtonSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        void SaveStorewiseQty()
        {
            foreach (GridViewRowInfo obj in dgStores.Rows)
            {
                var res = new StorewiseQuantityHelper().SaveEditStorewiseQty(new StorewiseQuantity
                {
                    StoreQuantityId = obj.Cells[0].Value == null ? 0 : Convert.ToInt32(obj.Cells[0].Value),
                    StoreId = Convert.ToInt32(obj.Cells[3].Value),
                    InventoryId = InventoryID,
                    Quantity = Convert.ToDecimal(obj.Cells[2].Value)
                });
            }
        }
        void LoadCategories()
        {
            ddlCategory.DataSource = new CategoryHelper().GetAllCategories();
            ddlCategory.DisplayMember = "Category1";
            ddlCategory.ValueMember = "CategoryId";
        }
        int SaveCategory()
        {
            var Id = new CategoryHelper().SaveEditCategory(new Category
            {
                Category1 = ddlCategory.Text
            });

            return Id;
        }
        void SaveItem()
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Enter Item Name");
                txtTitle.Focus();
                return;
            }
            if (txtSalePrice.Text == "")
            {
                MessageBox.Show("Enter Sale Price!");
                txtSalePrice.Focus();
                return;
            }
            if (txtMinSalePrice.Text == "")
            {
                MessageBox.Show("Enter Min Sale Price!");
                txtSalePrice.Focus();
                return;
            }

            Product obj = new Product();
            obj.ProductId = InventoryID;
            obj.Title = txtTitle.Text;
            obj.Descrioption = txtDescription.Text;
            obj.SalePrice = Convert.ToDecimal(txtSalePrice.Text);
            obj.MinSalePrice = Convert.ToDecimal(txtMinSalePrice.Text);
            obj.IsActive = chkActive.Checked;
            obj.IsExpirable = chkExpire.Checked;
            obj.Code1 = txtCode1.Text;
            obj.Code2 = txtCode2.Text;
            obj.Barcode = txtBarcode.Text;
            obj.RetailPrice = txtRPrice.Text == "" ? 0 : Convert.ToDecimal(txtRPrice.Text);
            obj.WholeSalePrice = txtWPrice.Text == "" ? 0 : Convert.ToDecimal(txtWPrice.Text);
            if (ddlCategory.Text != "")
            {
                obj.CategoryId = SaveCategory();
            }
            string fileName = pictureFileName;
            if (pictureData == null && fileName != "")
            {
                pictureData = File.ReadAllBytes(fileName);
                obj.Picture = pictureData;
            }
            else
            {

                if (fileName != "")
                {
                    pictureData = File.ReadAllBytes(fileName);
                    obj.Picture = pictureData;
                }
                else
                {
                    if (pictureData != null)
                        obj.Picture = pictureData;
                }
            }
            var res = new ProductHelper().SaveEditProduct(obj);
            if (res == true)
            {
                SaveStorewiseQty();

                if (InventoryID == 0)
                    ResetForm();
                else
                    this.Close();

                if (IL != null)
                    IL.LoadInventories();


                MessageBox.Show("Item changes saved successfully.");
            }

            if (res == false)
            {
                MessageBox.Show("An error occured while saving Item");
            }

            if (_MDIParent != null)
            {
                _MDIParent.RefreshWork();
            }


        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F2))
            {
                SaveItem();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void radButtonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;*.bmp)|*.jpg;*.jpeg;.*.gif;*.png;*.bmp";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                ItemPic.Image = new Bitmap(opnfd.FileName);
                ItemPic.ImageLayout = Telerik.WinControls.UI.RadImageLayout.Stretch;
                pictureFileName = opnfd.FileName;
            }
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkKg_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {

        }

        private void chkIsFeet_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtItemName.Focus();
            }
        }

        private void txtItemName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSalePrice.Focus();
            }
        }

        private void txtPacking_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMinSalePrice.Focus();
            }
        }

        private void txtUnit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
            }
        }

        private void chkKg_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    chkIsFeet.Focus();
            //}
        }

        private void chkIsFeet_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    txtDescription.Focus();
            //}
        }

        private void txtDescription_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtNote.Focus();
            }
        }

        private void txtPacking_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ddlCategory_Leave(object sender, EventArgs e)
        {

        }

        private void radTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtRPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtWPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMinSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "")
                txtBarcode.Text = new BarcodeHelper().GenerateBarcode();
        }
    }
}
