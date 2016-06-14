using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ALP_Desktop_2.Provider
{
    class InventoryProvider
    {
        private static String url = "http://seladanghijau.pe.hu/GetNextSerialNo.php";

        public static String getSerialNoByHttp()
        {
            HttpWebRequest httpRequest;
            HttpWebResponse httpResponse;
            StreamReader reader = null;

            JObject jsonObject;
            String jsonResponse;
            int serialNo = -1;

            try
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.KeepAlive = false;
                httpRequest.ProtocolVersion = HttpVersion.Version10;
                httpRequest.Method = "POST";
                httpRequest.ContentType = "application/x-www-form-urlencoded";

                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                reader = new StreamReader(httpResponse.GetResponseStream());

                jsonResponse = reader.ReadToEnd();
                jsonObject = JObject.Parse(jsonResponse);

                serialNo = Int32.Parse("" + jsonObject["SERIALNO"][0]["SERIALNO"]);
            } catch (Exception e) { Console.WriteLine(e.Message); }

            return serialNoFormat(serialNo);
        }

        public static String serialNoFormat(int serialNo)
        {
            return String.Format("{0:000000000}", serialNo);
        }

        public static String getCheckDigit(String number)
        {
            int sum = 0;
            int checkDigit = 0;

            try
            {
                for (int x = 0; x < number.Length; x++)
                {
                    char tempChar = number[x];
                    int tempNum = Int32.Parse("" + tempChar);

                    if (x % 2 == 0)
                    {
                        tempNum *= 2;

                        if (tempNum > 9)
                            tempNum -= 9;
                    }
                    else
                        tempNum *= 1;

                    sum += tempNum;
                }
                checkDigit = (sum * 9) % 10;
            } catch(Exception e) { Console.WriteLine(e.Message); }

            return "" + checkDigit;
        }
    }
}
