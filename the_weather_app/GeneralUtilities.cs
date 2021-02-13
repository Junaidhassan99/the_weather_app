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

        private string temp;
        private string cityName;
        private string imageIcon;
        private string feelsLike;
        private string pressure;
        private string humidity;
        private string windSpeed;
        private string windDirection;
        private string cloudCover;
        private string country;


        public CurrentWeather(string temp, string cityName, string imageIcon, string feelsLike,
            string pressure, string humidity, string windSpeed, string windDirection, string cloudCover,
            string country)
        {

            this.cityName = cityName;
            this.temp = temp;
            this.imageIcon = imageIcon;
            this.feelsLike = feelsLike;
            this.pressure = pressure;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
            this.windDirection = windDirection;
            this.cloudCover = cloudCover;
            this.country = country;
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


        public string ImageIcon
        {
            get
            {
                return imageIcon;
            }

            set
            {
                imageIcon = value;
            }
        }
        public string FeelsLike
        {
            get
            {
                return feelsLike;
            }

            set
            {
                feelsLike = value;
            }
        }
        public string Pressure
        {
            get
            {
                return pressure;
            }

            set
            {
                pressure = value;
            }
        }
        public string Humidity
        {
            get
            {
                return humidity;
            }

            set
            {
                humidity = value;
            }
        }
        public string WindSpeed
        {
            get
            {
                return windSpeed;
            }

            set
            {
                windSpeed = value;
            }
        }
        public string WindDirection
        {
            get
            {
                return windDirection;
            }

            set
            {
                windDirection = value;
            }
        }
        public string CloudCover
        {
            get
            {
                return cloudCover;
            }

            set
            {
                cloudCover = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

    }

    public class ApiUtilities
    {
        public static string getJsonStringResponse(string urlString)
        {
            Console.WriteLine("url  : {0}", urlString);

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

            /** public CurrentWeather(string temp, string cityName, string imageIcon, string feelsLike,
            string pressure, string humidity, string windSpeed, string windDirection, string cloudCover,
            string country)*/


            CurrentWeather currentWeather = new CurrentWeather(Convert.ToString(weatherData.main.temp), Convert.ToString(weatherData.name),
                Convert.ToString(weatherData.weather[0].icon), Convert.ToString(weatherData.main.feels_like), Convert.ToString(weatherData.main.pressure),
                Convert.ToString(weatherData.main.humidity), Convert.ToString(weatherData.wind.speed),
                Convert.ToString(weatherData.wind.deg), Convert.ToString(weatherData.clouds.all), Convert.ToString(weatherData.sys.country));



            return currentWeather;
        }

        public static string getImageUrl(string keyword)
        {

            return "http://openweathermap.org/img/wn/" + keyword + "@2x.png";

        }

        public static string convertKelvenToCelcius(string kelven)
        {
            double celcius;
            celcius = Math.Round(double.Parse(kelven) - 273, 2);

            return Convert.ToString(celcius);
        }

    }
}
