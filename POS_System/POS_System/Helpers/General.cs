using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public static class General
{
    static string[] ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    static string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    static string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    static string[] thousandsGroups = { "", " Thousand", " Million", " Billion" };

    private static string Integer(int n, string leftDigits, int thousands)
    {
        if (n == 0)
        {
            return leftDigits;
        }
        string friendlyInt = leftDigits;
        if (friendlyInt.Length > 0)
        {
            friendlyInt += " ";
        }
        if (n < 10)
        {
            friendlyInt += ones[n];
        }
        else if (n < 20)
        {
            friendlyInt += teens[n - 10];
        }
        else if (n < 100)
        {
            friendlyInt += Integer(n % 10, tens[n / 10 - 2], 0);
        }
        else if (n < 1000)
        {
            friendlyInt += Integer(n % 100, (ones[n / 100] + " Hundred"), 0);
        }
        else
        {
            friendlyInt += Integer(n % 1000, Integer(n / 1000, "", thousands + 1), 0);
        }

        return friendlyInt + thousandsGroups[thousands];
    }

    public static string DateToWord(DateTime date)
    {
        return string.Format("{0} {1} {2}", IntegerToWord(date.Day), date.ToString("MMMM"), IntegerToWord(date.Year));
    }

    public static string IntegerToWord(int n)
    {
        if (n == 0)
        {
            return "Zero";
        }
        else if (n < 0)
        {
            return "Negative " + IntegerToWord(-n);
        }
        return Integer(n, "", 0);
    }

    public static DataTable ToDataTable<T>(this List<T> items)
    {
        var tb = new DataTable(typeof(T).Name);

        PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var prop in props)
        {
            tb.Columns.Add(prop.Name, prop.PropertyType);
        }

        foreach (var item in items)
        {
            var values = new object[props.Length];
            for (var i = 0; i < props.Length; i++)
            {
                values[i] = props[i].GetValue(item, null);
            }

            tb.Rows.Add(values);
        }

        return tb;
    }

    private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
    {
        //Get the image current width  
        int sourceWidth = imgToResize.Width;
        //Get the image current height  
        int sourceHeight = imgToResize.Height;
        float nPercent = 0;
        float nPercentW = 0;
        float nPercentH = 0;
        //Calulate  width with new desired size  
        nPercentW = ((float)size.Width / (float)sourceWidth);
        //Calculate height with new desired size  
        nPercentH = ((float)size.Height / (float)sourceHeight);
        if (nPercentH < nPercentW)
            nPercent = nPercentH;
        else
            nPercent = nPercentW;
        //New Width  
        int destWidth = (int)(sourceWidth * nPercent);
        //New Height  
        int destHeight = (int)(sourceHeight * nPercent);
        Bitmap b = new Bitmap(destWidth, destHeight);
        Graphics g = Graphics.FromImage((System.Drawing.Image)b);
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        // Draw image with new width and height  
        g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
        g.Dispose();
        return (System.Drawing.Image)b;
    }
    public static Image ResizePicture(byte[] image, int width, int height)
    {
        Image img = null;
        if (image != null)
        {
            var pictureData = image;
            img = System.Drawing.Image.FromStream(new MemoryStream(pictureData));
            Bitmap b = new Bitmap(img);
            img = resizeImage(b, new Size(width, height));
        }
        else
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Images\No-Image.png");
            img = System.Drawing.Image.FromFile(path);
            Bitmap b = new Bitmap(img);
            img = resizeImage(b, new Size(width, height));
        }
        return img;
    }
    public static Image ResizePicture(string imageName, int width, int height)
    {
        Image img = null;
        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Images\" + imageName);
        img = System.Drawing.Image.FromFile(path);
        Bitmap b = new Bitmap(img);
        img = resizeImage(b, new Size(width, height));
        return img;
    }
}

