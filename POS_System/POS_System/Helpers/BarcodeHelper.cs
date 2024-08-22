
using Spire.Barcode;
using System;
using System.Collections.Generic;
using System.Drawing;

public class BarcodeHelper
{
    public string GenerateBarcode()
    {
        //Country code -2 or 3 digits
        //Manufacturer Code - 5 to 7 digits
        //Product Code - 3 to 5 digits
        //Check digit - last digit
        Random rnd = new Random();
        int CountryCode = rnd.Next(999);
        int mCode = rnd.Next(9999999);
        int pCode = rnd.Next(99999);
        int lDigit = rnd.Next(9);
        
        BarcodeSettings settings = new BarcodeSettings();
        settings.Type = BarCodeType.EAN13;
        settings.Data = CountryCode.ToString() + mCode.ToString() + pCode.ToString() + lDigit.ToString(); //"123456789018";
        
        settings.UseChecksum = CheckSumMode.ForceEnable;
        settings.ShowTextOnBottom = true;
        settings.TextAlignment = StringAlignment.Center;
        BarCodeGenerator generator = new BarCodeGenerator(settings);
         
        Image image = generator.GenerateImage();
        var data = BarcodeScanner.Scan((Bitmap)image);
        return data[0];
        //image.Save("EAN-13.png", System.Drawing.Imaging.ImageFormat.Png);

    }
}

