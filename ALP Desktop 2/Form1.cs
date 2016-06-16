using System;
using System.Windows.Forms;
using System.Threading;
using ALP_Desktop_2.Provider;
using ALP_Desktop_2.DTO;
using System.Collections.Generic;
using System.Drawing;

namespace ALP_Desktop_2
{
    public partial class MainWindow : Form
    {
        List<Inventory> inventoryList;
        Inventory inventory;

        private Font statusFont;
        private Brush statusBrush;
        private Bitmap statusBitmap;
        private Graphics statusGraphics;

        public MainWindow()
        {
            InitializeComponent();

            // main process ---------------------------------------------------
            statusFont = new Font("Courier New", 12);
            statusBrush = new SolidBrush(Color.Black);
            statusBitmap = new Bitmap((AssetLabel.LABEL_WIDTH * 2), (AssetLabel.LABEL_HEIGHT * 2));
            statusGraphics = Graphics.FromImage(statusBitmap);

            if (imgQRImage.Image == null)
                btnPrintQRCode.Enabled = false;
            // ----------------------------------------------------------------
        }

        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            statusGraphics.Clear(Color.White);
            statusGraphics.DrawImage(statusBitmap, 100, 100);
            statusGraphics.DrawString("Generating Qr Code...", statusFont, statusBrush, (AssetLabel.LABEL_WIDTH / 2), (AssetLabel.LABEL_HEIGHT / 2));
            imgQRImage.Image = statusBitmap;

            new Thread(new ThreadStart(generateAssetLabel)).Start(); // setup asset label image in saperate thread

            btnPrintQRCode.Enabled = true;
        }

        private void btnPrintQRCode_Click(object sender, EventArgs e)
        {
            for(int x=0; x<inventoryList.Count; x++)
            {
                PrinterProvider.assetLabelList.Add(inventoryList[x].AssetLabel);
            }

            PrinterProvider.PrintAsset(); // print the image
        }
        
        public void generateAssetLabel()
        {
            inventoryList = new List<Inventory>(); // initialize list to store inventory items

            // get value from window form -------------------------------------
            String serviceProvider = txtServiceProvider.Text;
            String projectCode = txtProjectCode.Text;
            String serviceProviderContact = txtServiceProviderContact.Text;
            int printNo = Int32.Parse("" + numPrintNo.Value);
            // ----------------------------------------------------------------

            // setup inventory DTO ------------------------------------------------
            for(int x=0; x<printNo; x++)
            {
                inventory = new Inventory(); // initialize inventory variable, used to store temporary inventory data
                inventory.ServiceProvider = serviceProvider;
                inventory.ProjectCode = projectCode;
                inventory.ServiceProviderContact = serviceProviderContact;
                inventory.SerialNo = Provider.InventoryProvider.getSerialNoByHttp();
                inventory.LuhnCheck = Provider.InventoryProvider.getCheckDigit(inventory.SerialNo);
                inventory.InventorySerialNo = inventory.ProjectCode + inventory.SerialNo + inventory.LuhnCheck;
                inventory.QRCode = QRCodeProvider.getQREncodeBitmap(inventory.InventorySerialNo, 0, (AssetLabel.QR_WIDTH * 2), (AssetLabel.QR_HEIGHT * 2));
                inventory.AssetLabel = QRCodeProvider.getAssetLabel(inventory.QRCode, serviceProvider, serviceProviderContact, inventory.InventorySerialNo);

                inventoryList.Add(inventory); // add newly created inventory into inventoryList
            }

            inventoryList.TrimExcess(); // trim the excess data space in inventoryList to reduce memory addressing
            // ----------------------------------------------------------------

            imgQRImage.Image = inventory.AssetLabel; // present the asset label in Window Form
        }
    }
}
