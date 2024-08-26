
using System.Windows.Forms;
using System;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Drawing;

public class BottomView : LightVisualElement, IGridView
{
    RadGridViewElement element;
    GridViewInfo viewInfo;
    RadButtonElement button1 = new RadButtonElement("Add");
    RadButtonElement button2 = new RadButtonElement("Remove");
    int btnHight;
    #region IGridView Members

    public BottomView(string buttonText, int buttonHeight)
    {
            button1.Text = buttonText;  
             btnHight = buttonHeight;   
    }
    public RadButtonElement Button1
    {
        get
        {
            return this.button1;
        }
    }

    public RadGridViewElement GridViewElement
    {
        get
        {
            return element;
        }
    }

    public GridViewInfo ViewInfo
    {
        get
        {
            return viewInfo;
        }
    }

    public void Initialize(RadGridViewElement gridViewElement, GridViewInfo viewInfo)
    {
        this.element = gridViewElement;
        this.viewInfo = viewInfo;
    }

    public void UpdateView()
    {
    }

    public void Detach()
    {
    }

    #endregion

    protected override void InitializeFields()
    {
        base.InitializeFields();
        this.StretchHorizontally = true;
        this.StretchVertically = false;
        this.MaxSize = new Size(0, btnHight);
        this.MinSize = new Size(0, btnHight);
        this.Padding = new Padding(3);
    }

    protected override void CreateChildElements()
    {
        base.CreateChildElements();

        button1.StretchHorizontally = true;
        button1.StretchVertically = true;
        //button1.Click += button1_Click;

        button2.StretchHorizontally = true;
        button2.StretchVertically = true;

        StackLayoutElement stack = new StackLayoutElement();
        stack.StretchHorizontally = true;
        stack.StretchVertically = true;
        stack.Children.Add(button1);
        //stack.Children.Add(button2);
        this.Children.Add(stack);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        RadMessageBox.Show("Add button is clicked");
    }
}

