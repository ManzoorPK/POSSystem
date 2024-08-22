using System;
using System.Collections.Generic;
//using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Common
{
    public static string GetAsMoney(object value)
    {
       return String.Format("{0:0.00}", value).ToString();
    }
    public static string GetAsMoneyWithComma(object value)
    {
        return String.Format("{0:N0}", value).ToString();
    }
    public static string StringFormat()
    {
        return "{0:N0}";
    }
    //public static Image ConvertToImage(Binary iBinary)
    //{
    //    var arrayBinary = iBinary.ToArray();
    //    Image rImage = null;

    //    using (MemoryStream ms = new MemoryStream(arrayBinary))
    //    {
    //        rImage = Image.FromStream(ms);
    //    }
    //    return rImage;
    //}

  
}

