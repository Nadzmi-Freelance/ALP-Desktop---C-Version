using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ALP_Desktop_2.Provider;
using ZXing.QrCode.Internal;
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
            inventory = new Inventory();
            // ----------------------------------------------------------------
        }

        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(setupAssetLabelImg)).Start();
        }

        private void btnPrintQRCode_Click(object sender, EventArgs e)
        {
            PrinterProvider.PrintAsset(inventory.AssetLabel);
        }
        
        public void setupAssetLabelImg()
        {
            // get value from window form -------------------------------------
            String serviceProvider = txtServiceProvider.Text;
            String projectCode = txtProjectCode.Text;
            String serviceProviderContact = txtServiceProviderContact.Text;
            // ----------------------------------------------------------------

            // setup inventory ------------------------------------------------
            inventory.ServiceProvider = serviceProvider;
            inventory.ProjectCode = projectCode;
            inventory.ServiceProviderContact = serviceProviderContact;
            inventory.SerialNo = Provider.InventoryProvider.getSerialNoByHttp();
            inventory.LuhnCheck = Provider.InventoryProvider.getCheckDigit(inventory.SerialNo);
            inventory.InventorySerialNo = inventory.ProjectCode + inventory.SerialNo + inventory.LuhnCheck;
            inventory.QRCode = QRCodeProvider.getQREncodeBitmap(inventory.InventorySerialNo, 0, (AssetLabel.QR_WIDTH * 2), (AssetLabel.QR_HEIGHT * 2));
            inventory.AssetLabel = QRCodeProvider.getAssetLabel(inventory.QRCode, serviceProvider, serviceProviderContact, inventory.InventorySerialNo);
            // ----------------------------------------------------------------

            imgQRImage.Image = inventory.AssetLabel;
        }
    }
}
