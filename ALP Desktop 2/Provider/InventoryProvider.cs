using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

namespace ALP_Desktop_2.Provider
{
    class InventoryProvider
    {
        private static string url = "http://seladanghijau.pe.hu/GetNextSerialNo.php";

        public static string getSerialNoByHttp()
        {
            HttpWebRequest httpRequest;
            HttpWebResponse httpResponse;
            StreamReader reader = null;

            JObject jsonObject;
            string jsonResponse;
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

        public static string serialNoFormat(int serialNo)
        {
            return string.Format("{0:000000000}", serialNo);
        }

        public static string getCheckDigit(string number)
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
