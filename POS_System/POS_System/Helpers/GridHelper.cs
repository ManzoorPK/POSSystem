using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

public class GridHelper
{
    public GridViewCommandColumn AddCommandButton(CommandButton col)
    {
        GridViewCommandColumn command = new GridViewCommandColumn();
        command.Name = col.name;
        command.HeaderText = col.headerText;
        command.Width = 100; //col.Width;
        command.FieldName = col.fieldName;
        //command.UseDefaultText = true;
        if (col.name == "btnSelect")
        {
            command.Image = General.ResizePicture("attach.png", col.icon_Width, col.icon_Height);
            command.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            command.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            command.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            command.Tag = "Select To Print";
        }
        if (col.name == "btnSendSms")
        {
            command.Image = General.ResizePicture("sms.png", col.icon_Width, col.icon_Height);
            command.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            command.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            command.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
        }
        if (col.name == "btnEdit")
        {
            command.Image = General.ResizePicture("edit1.png", col.icon_Width, col.icon_Height);
            command.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            command.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            command.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            command.Tag = "Edit";
        }
        if (col.name == "btnOpen")
        {
            command.Image = General.ResizePicture("session.png", col.icon_Width, col.icon_Height);
            command.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            command.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            command.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            command.Tag = "Open";
        }
        if (col.name == "btnDelete")
        {
            command.Image = General.ResizePicture("del1.png", col.icon_Width, col.icon_Height);
            command.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            command.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
        }

        return command;
    }

    public void GridCellFormatting(object sender, CellFormattingEventArgs e)
    {

        Font f = new Font(new FontFamily("Arial"), 8.0f);
        e.CellElement.Font = f;

        if (e.CellElement.ColumnInfo is GridViewCommandColumn)
        {
            // This is how we get the RadButtonElement instance from the cell
            RadButtonElement button = (RadButtonElement)e.CellElement.Children[0];

            //if (e.CellElement.RowInfo.Cells["cmdEdit"].Value != null)
            //{
            //int id = (int)e.CellElement.RowInfo.Cells["cmdEdit"].Value;
            if (e.CellElement.ColumnInfo.Name == "btnEdit")
            {
                button.Text = "Edit";
                button.TextAlignment = ContentAlignment.MiddleCenter;
                //button.BackColor = Color.Blue;

                //button.SetThemeValueOverride(Telerik.WinControls.Primitives.FillPrimitive.BackColorProperty, Color.White, "",
                //    typeof(Telerik.WinControls.Primitives.FillPrimitive));

                 
                //button.SetThemeValueOverride(Telerik.WinControls.Primitives.FillPrimitive.GradientStyleProperty, GradientStyles.Solid, "",
                //    typeof(Telerik.WinControls.Primitives.FillPrimitive));

            }

            if (e.CellElement.ColumnInfo.Name == "btnDelete")
            {
                button.Text = "Delete";
                button.TextAlignment = ContentAlignment.MiddleCenter;
                //button.BackColor = Color.Red;
                //button.SetThemeValueOverride(Telerik.WinControls.Primitives.FillPrimitive.BackColorProperty, Color.White, "",
                //   typeof(Telerik.WinControls.Primitives.FillPrimitive));


                //button.SetThemeValueOverride(Telerik.WinControls.Primitives.FillPrimitive.GradientStyleProperty, GradientStyles.Solid, "",
                //    typeof(Telerik.WinControls.Primitives.FillPrimitive));
            }

            //if (e.CellElement.ColumnInfo.Name == "btnOpen")
            //{
            //    button.Text = "View";
            //    button.TextAlignment = ContentAlignment.MiddleCenter;
            //    button.BackColor = Color.Green;
            //}

            //if (e.CellElement.ColumnInfo.Name == "btnSelect")
            //{
            //    button.Text = "Select";
            //    button.TextAlignment = ContentAlignment.MiddleCenter;
            //    button.BackColor = Color.Green;
            //}
            //}
        }
    }

    public void SetButton(RadButton btn, string imageName, int width = 20, int height = 20)
    {
        btn.Image = General.ResizePicture(imageName, width, height);
        btn.ImageAlignment = ContentAlignment.MiddleLeft;
        //btn.TextAlignment = ContentAlignment.MiddleCenter;
        btn.Padding = new Padding(10, 0, 0, 0);

    }

    public void SetButtonDashboard(RadButton btn, string imageName, int width = 20, int height = 20)
    {
        btn.Image = General.ResizePicture(imageName, width, height);
        btn.TextImageRelation = TextImageRelation.ImageAboveText;
        btn.ImageAlignment = ContentAlignment.TopCenter;
        RoundRectShape shape = new RoundRectShape(10);
        //RadButton
        btn.ButtonElement.Shape = shape;
        btn.ButtonElement.BackColor = Color.AliceBlue;
        btn.Padding = new Padding(10, 0, 0, 0);
    }

    public void SetGridHeaderAlignment(RadGridView radGrid, ContentAlignment alignment)
    {
        foreach (var c in radGrid.Columns)
        {
            c.HeaderTextAlignment = alignment;
        }

        for (int i = 0; i < radGrid.Columns.Count; i ++)
        {
            GridViewDataRowInfo iRow = new GridViewDataRowInfo(radGrid.MasterView);
            iRow.Cells[i].ColumnInfo.TextAlignment = alignment;
        }
    }
}

public class CommandButton
{
    public CommandButton(string _name, string _headerText, int _width, string _fieldName = "", int _iconWidth = 25, int _iconHeight = 25)
    {
        name = _name;
        headerText = _headerText;
        Width = _width;
        icon_Height = _iconHeight;
        icon_Width = _iconWidth;
        fieldName = _fieldName;
    }
    public string name { get; set; }
    public string headerText { get; set; }
    public int Width { get; set; }
    public int icon_Width { get; set; }
    public int icon_Height { get; set; }
    public string fieldName { get; set; }
}