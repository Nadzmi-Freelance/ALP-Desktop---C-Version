using ALP_Desktop_2.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace ALP_Desktop_2.Provider
{
    class QRCodeProvider
    {
        public static Bitmap getQREncodeBitmap(String code, int margin, int width, int height)
        {
            BarcodeWriter qrWriter;
            QrCodeEncodingOptions options;
            Bitmap qrBitmap = null;

            try
            {
                options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Margin = margin,
                    Width = width,
                    Height = height
                };
                qrWriter = new BarcodeWriter();
                qrWriter.Format = BarcodeFormat.QR_CODE;
                qrWriter.Options = options;

                qrBitmap = new Bitmap(qrWriter.Write(code));
            } catch(Exception e) { Console.WriteLine(e.Message); }

            return qrBitmap;
        }

        public static Bitmap getAssetLabel(Bitmap qrBitmap, String serviceProvider, String serviceProviderContact, String inventorySerialNo)
        {
            Font textFont;
            SolidBrush textBrush;
            Graphics assetLabelGraphics = null;
            Bitmap assetLabel = null;

            String fileName = "qr_sheet.png";
            String imgPath = Path.Combine(Environment.CurrentDirectory, @"Resources\Images\", fileName);

            try
            {
                textBrush = new SolidBrush(Color.Black);
                textFont = new Font("Arial", 20);
                assetLabel = new Bitmap((AssetLabel.LABEL_WIDTH * 2), (AssetLabel.LABEL_HEIGHT * 2));
                assetLabelGraphics = Graphics.FromImage(assetLabel);

                // draw asset label
                assetLabelGraphics.Clear(Color.White);
                assetLabelGraphics.DrawImage(qrBitmap, (assetLabel.Width / 20), (assetLabel.Height / 10));
                assetLabelGraphics.DrawString(serviceProvider, textFont, textBrush, (assetLabel.Width / 2.5f), (assetLabel.Height / 3));
                assetLabelGraphics.DrawString(("Tel: " + serviceProviderContact), textFont, textBrush, (assetLabel.Width / 2.5f), (assetLabel.Height / 2));
                assetLabelGraphics.DrawString(inventorySerialNo, textFont, textBrush, (assetLabel.Width / 2.5f), (assetLabel.Height / 1.5f));
            } catch(Exception e) { Console.WriteLine(e.Message); }

            return assetLabel;
        }
    }
}
