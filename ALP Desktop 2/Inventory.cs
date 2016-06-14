using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALP_Desktop_2.Provider;

namespace ALP_Desktop_2
{
    class Inventory
    {
        private String serviceProvider, serviceProviderContact;
        private String projectCode;
        private String serialNo, luhnCheck, inventorySerialNo;

        public Inventory()
        {
            serviceProvider = "";
            serviceProviderContact = "";
            projectCode = "";
            serialNo = "";
            luhnCheck = "";
            inventorySerialNo = "";
        }

        public String ServiceProvider { get; set; }
        public String ServiceProviderContact { get; set; }
        public String ProjectCode { get; set; }
        public String SerialNo { get; set; }
        public String LuhnCheck { get; set; }
        public String InventorySerialNo { get; set; }
    }
}
