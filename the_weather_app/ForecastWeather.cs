using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_weather_app
{
    public class ForecastWeather:WeatherData
    {
        
        private string dateText;


        public ForecastWeather(string temp, string imageIcon, string feelsLike,
            string pressure, string humidity, string windSpeed, string windDirection, string cloudCover,
            string dateText
            ):base(temp, imageIcon, feelsLike,pressure, humidity, windSpeed, windDirection, cloudCover)
        {

            this.dateText = dateText;

        }



       


        public string DateText
        {
            get
            {
                return dateText;
            }

            set
            {
                dateText = value;
            }
        }


    }
}
