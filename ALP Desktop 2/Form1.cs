using System;
using System.Windows.Forms;
using System.Threading;
using ALP_Desktop_2.Provider;
using ALP_Desktop_2.DTO;

namespace ALP_Desktop_2
{
    public partial class MainWindow : Form
    {
        Inventory inventory;

        public MainWindow()
        {
            InitializeComponent();

            // main process ---------------------------------------------------
            inventory = new Inventory(); // initialize inventory variable, used to store temporary inventory data
            // ----------------------------------------------------------------
        }

        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(generateAssetLabel)).Start(); // setup asset label image in saperate thread
        }

        private void btnPrintQRCode_Click(object sender, EventArgs e)
        {
            PrinterProvider.assetLabel = inventory.AssetLabel; // set the image that user want to print
            PrinterProvider.PrintAsset(); // print the image
        }
        
        public void generateAssetLabel()
        {
            // get value from window form -------------------------------------
            String serviceProvider = txtServiceProvider.Text;
            String projectCode = txtProjectCode.Text;
            String serviceProviderContact = txtServiceProviderContact.Text;
            // ----------------------------------------------------------------

            // setup inventory DTO ------------------------------------------------
            inventory.ServiceProvider = serviceProvider;
            inventory.ProjectCode = projectCode;
            inventory.ServiceProviderContact = serviceProviderContact;
            inventory.SerialNo = Provider.InventoryProvider.getSerialNoByHttp();
            inventory.LuhnCheck = Provider.InventoryProvider.getCheckDigit(inventory.SerialNo);
            inventory.InventorySerialNo = inventory.ProjectCode + inventory.SerialNo + inventory.LuhnCheck;
            inventory.QRCode = QRCodeProvider.getQREncodeBitmap(inventory.InventorySerialNo, 0, (AssetLabel.QR_WIDTH * 2), (AssetLabel.QR_HEIGHT * 2));
            inventory.AssetLabel = QRCodeProvider.getAssetLabel(inventory.QRCode, serviceProvider, serviceProviderContact, inventory.InventorySerialNo);
            // ----------------------------------------------------------------

            imgQRImage.Image = inventory.AssetLabel; // present the asset label in Window Form
        }
    }
}
