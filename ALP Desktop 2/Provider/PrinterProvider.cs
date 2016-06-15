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
        public static Bitmap assetLabel;

        public static void PrintAsset()
        {
            PrintDialog printDialog;
            PrintDocument printDoc;
            DialogResult dialogResult;

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
            Graphics graphics;

            graphics = e.Graphics;
            graphics.DrawImage(assetLabel, 0, 0, AssetLabel.LABEL_WIDTH, AssetLabel.LABEL_HEIGHT);
        }
    }
}
