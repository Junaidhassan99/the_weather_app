using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace the_weather_app
{
    class GeneralUtilities
    {
    }

    public class ApiUtilities
    {
        public static string getJsonStringResponse(string urlString)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(urlString);

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Console.WriteLine(WebResp.StatusCode);
            Console.WriteLine(WebResp.Server);

            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            //List<Item> items = JsonConvert.DeserializeObject<List<Item>>(jsonString);

            return jsonString;

        }

        public static string getWeatherByCityName(string cityName)
        {
            string urlString = Credentials.initialApiSearchByCity + "?q=" + cityName + "&appid=" + Credentials.apiKey;
            return ApiUtilities.getJsonStringResponse(urlString);
        }

    }
}
