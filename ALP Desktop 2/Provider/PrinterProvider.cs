using ALP_Desktop_2.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_Desktop_2.Provider
{
    class PrinterProvider
    {
        private static Bitmap asset;

        public static void PrintAsset(Bitmap assetLabel)
        {
            PrintDialog printDialog;
            PrintDocument printDoc;
            DialogResult dialogResult;

            asset = assetLabel;

            printDialog = new PrintDialog();
            printDoc = new PrintDocument();

            printDialog.Document = printDoc;
            printDoc.PrintPage += PrintDoc_PrintPage;
            dialogResult = printDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private static void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font;
            Graphics graphics;

            graphics = e.Graphics;
            font = new Font("Courier New", 12);

            graphics.DrawImage(asset, 0, 0, AssetLabel.LABEL_WIDTH, AssetLabel.LABEL_HEIGHT);
        }
    }
}
