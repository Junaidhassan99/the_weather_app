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

    public class CurrentWeather
    {
        private string coordinate;
        private string temp;
        private string cityName;

        public CurrentWeather(string coordinated, string temp, string cityName)
        {
            this.coordinate = coordinated;
            this.cityName = cityName;
            this.temp = temp;
        }

        public string Coordinate
        {
            get
            {
                return coordinate;
            }

            set
            {
                coordinate = value;
            }
        }

        public string Temp
        {
            get
            {
                return temp;
            }

            set
            {
                temp = value;
            }
        }

        public string CityName
        {
            get
            {
                return cityName;
            }

            set
            {
                cityName = value;
            }
        }
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


            return jsonString;

        }

        public static CurrentWeather getWeatherByCityName(string cityName)
        {
            string urlString = Credentials.initialApiSearchByCity + "?q=" + cityName + "&appid=" + Credentials.apiKey;

            string jsonResponse = ApiUtilities.getJsonStringResponse(urlString);

            dynamic weatherData = JsonConvert.DeserializeObject(jsonResponse);

            Console.WriteLine("test : {0}", weatherData.name);


            CurrentWeather currentWeather = new CurrentWeather(Convert.ToString(weatherData.coord.lon + " , " + weatherData.coord.lat), Convert.ToString(weatherData.main.temp), Convert.ToString(weatherData.name));



            return currentWeather;
        }

    }
}
