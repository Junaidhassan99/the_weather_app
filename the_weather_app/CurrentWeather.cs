using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_weather_app
{
    public class CurrentWeather: WeatherData
    {

       
        private string cityName;
        private string country;


        public CurrentWeather(string temp, string cityName, string imageIcon, string feelsLike,
            string pressure, string humidity, string windSpeed, string windDirection, string cloudCover,
            string country) : base(temp, imageIcon, feelsLike, pressure, humidity, windSpeed, windDirection, cloudCover)
        {

            this.cityName = cityName;
            this.country = country;
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
}
