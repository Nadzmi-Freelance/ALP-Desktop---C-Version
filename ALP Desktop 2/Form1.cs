using System;
using System.Windows.Forms;
using System.Threading;
using ALP_Desktop_2.Provider;
using ALP_Desktop_2.DTO;
using System.Collections.Generic;

namespace ALP_Desktop_2
{
    public partial class MainWindow : Form
    {
        List<Inventory> inventoryList;
        Inventory inventory;

        public MainWindow()
        {
            InitializeComponent();

            // main process ---------------------------------------------------
            // ----------------------------------------------------------------
        }

        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(generateAssetLabel)).Start(); // setup asset label image in saperate thread
        }

        private void btnPrintQRCode_Click(object sender, EventArgs e)
        {
            // testing purpose
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
