using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALP_Desktop_2.Provider;
using System.Drawing;

namespace ALP_Desktop_2
{
    class Inventory
    {
        private String serviceProvider, serviceProviderContact;
        private String projectCode;
        private String serialNo, luhnCheck, inventorySerialNo;
        private Bitmap qrCode, assetLabel;

        public Inventory()
        {
            serviceProvider = "";
            serviceProviderContact = "";
            projectCode = "";
            serialNo = "";
            luhnCheck = "";
            inventorySerialNo = "";
            qrCode = null;
            assetLabel = null;
        }

        public String ServiceProvider { get; set; }
        public String ServiceProviderContact { get; set; }
        public String ProjectCode { get; set; }
        public String SerialNo { get; set; }
        public String LuhnCheck { get; set; }
        public String InventorySerialNo { get; set; }
        public Bitmap QRCode { get; set; }
        public Bitmap AssetLabel { get; set; }
    }
}
