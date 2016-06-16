using ALP_Desktop_2.DTO;
using System;
using System.Drawing;
using System.IO;
using ZXing;
using ZXing.QrCode;

namespace ALP_Desktop_2.Provider
{
    class QRCodeProvider
    {
        public static Bitmap getQREncodeBitmap(string code, int margin, int width, int height) // encode invecntorySerialNo -> QR Code -> bitmap image
        {
            BarcodeWriter qrWriter; // used to write(encode) string to qr code
            QrCodeEncodingOptions options; // used to setup encoding options(height, width, margin, color, etc...)
            Bitmap qrBitmap = null; // used to present the Qr Code 

            try
            {
                // initialize encoding options
                options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Margin = margin,
                    Width = width,
                    Height = height
                };
                qrWriter = new BarcodeWriter(); // declare BarcodeWriter
                qrWriter.Format = BarcodeFormat.QR_CODE; // set barcode format as QR Code
                qrWriter.Options = options; // install encoding option to barcodewriter

                qrBitmap = new Bitmap(qrWriter.Write(code)); // present encoded QR Code as bitmap
            } catch(Exception e) { Console.WriteLine(e.Message); }

            return qrBitmap; // return encoded QR Code in bitmap
        }

        public static Bitmap getAssetLabel(Bitmap qrBitmap, string serviceProvider, string serviceProviderContact, string inventorySerialNo) // arrange QR with full asset labe and combine into 1 bitmap
        {
            Font textFont; // used to setup the font of asset label
            SolidBrush textBrush; // used to setup brush to write for asset label
            Graphics assetLabelGraphics = null; // used to organize elements in bitmap
            Bitmap assetLabel = null; // represent full asset label image

            try
            {
                // initialize graphics related editing tools
                textBrush = new SolidBrush(Color.Black); // initialize brush
                textFont = new Font("Arial", 16, FontStyle.Bold); // initialize font
                assetLabel = new Bitmap((AssetLabel.LABEL_WIDTH * 2), (AssetLabel.LABEL_HEIGHT * 2)); // initialize asset label image
                assetLabelGraphics = Graphics.FromImage(assetLabel); // initialize graphic editor, to be able to edit the assetLabel image

                // draw QR Code & asset label on 1 bitmap
                assetLabelGraphics.Clear(Color.White);
                assetLabelGraphics.DrawImage(qrBitmap, (assetLabel.Width / 20), (assetLabel.Height / 10)); // draw QR Code
                assetLabelGraphics.DrawString(serviceProvider, textFont, textBrush, (assetLabel.Width / 2.5f), (assetLabel.Height / 3.6f)); // draw label for service provider name
                assetLabelGraphics.DrawString(("Tel: " + serviceProviderContact), textFont, textBrush, (assetLabel.Width / 2.5f), (assetLabel.Height / 2.1f)); // draw label for service provider contact no
                assetLabelGraphics.DrawString(inventorySerialNo, textFont, textBrush, (assetLabel.Width / 2.5f), (assetLabel.Height / 1.5f)); // draw label for inventory serial no
            } catch(Exception e) { Console.WriteLine(e.Message); }

            return assetLabel; // return complete asset label with qr code in bitmap image
        }
    }
}
