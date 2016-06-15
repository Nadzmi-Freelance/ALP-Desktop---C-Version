using ALP_Desktop_2.DTO;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
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
            PageSettings pageSettings;
            PrinterSettings printerSettings;

            DialogResult dialogResult;
            IEnumerable<PaperSize> paperSizes;

            // initialize ---------------------------------------------
            printDialog = new PrintDialog();
            printDoc = new PrintDocument();
            pageSettings = new PageSettings();
            printerSettings = new PrinterSettings();
            // --------------------------------------------------------

            // setup page setting -------------------------------------
            pageSettings.Landscape = false;
            // --------------------------------------------------------

            // setup printer setting ----------------------------------
            printDoc.PrinterSettings = printerSettings; // get current printer setting
            paperSizes = printerSettings.PaperSizes.Cast<PaperSize>(); // get list of paper size
            printDoc.DefaultPageSettings.PaperSize = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4); // setting paper size to A4 size
            // --------------------------------------------------------

            // setup print document setting ---------------------------
            printDoc.PrinterSettings = printerSettings;// set printer settings
            printDoc.DefaultPageSettings = pageSettings; // set default page setting
            printDoc.PrintPage += PrintDoc_PrintPage; // show print page setting
            // --------------------------------------------------------

            printDialog.Document = printDoc; // set value of printDocument used to obtain printerSettings
            dialogResult = printDialog.ShowDialog(); // show print dialog

            if(dialogResult == DialogResult.OK)
                printDoc.Print();
        }

        private static void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics;

            graphics = e.Graphics;
            graphics.DrawImage(assetLabel, 0, 0, AssetLabel.LABEL_WIDTH, AssetLabel.LABEL_HEIGHT);
        }
    }
}
