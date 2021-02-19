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

        public static List<ForecastWeather> getForecastWeatherByCityName(string cityName)
        {
            string urlString = Credentials.initialApiForcasteSearchByCity + "?q=" + cityName + "&appid=" + Credentials.apiKey;



            string jsonResponse = ApiUtilities.getJsonStringResponse(urlString);

            //decode json string respnse to list of forecaste weather data
            dynamic weatherData = JsonConvert.DeserializeObject(jsonResponse);
            List<dynamic> weatherDataList = JsonConvert.DeserializeObject<List<dynamic>>(JsonConvert.SerializeObject(weatherData.list));

            Console.WriteLine("test : {0}", weatherDataList.Count);

            List<ForecastWeather> forecastWeatherDataList = new List<ForecastWeather>();

            foreach (dynamic weatherDataListElement in weatherDataList)
            {

                forecastWeatherDataList.Add(new ForecastWeather(Convert.ToString(weatherDataListElement.main.temp),
                Convert.ToString(weatherDataListElement.weather[0].icon), Convert.ToString(weatherDataListElement.main.feels_like), Convert.ToString(weatherDataListElement.main.pressure),
                Convert.ToString(weatherDataListElement.main.humidity), Convert.ToString(weatherDataListElement.wind.speed),
                Convert.ToString(weatherDataListElement.wind.deg), Convert.ToString(weatherDataListElement.clouds.all),
                Convert.ToString(weatherDataListElement.dt_txt)));

            }

            return forecastWeatherDataList;
        }

        public static CurrentWeather getCurrentWeatherByCityName(string cityName)
        {
            string urlString = Credentials.initialApiSearchByCity + "?q=" + cityName + "&appid=" + Credentials.apiKey;



            string jsonResponse = ApiUtilities.getJsonStringResponse(urlString);

            dynamic weatherData = JsonConvert.DeserializeObject(jsonResponse);

            Console.WriteLine("test : {0}", weatherData.name);




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
