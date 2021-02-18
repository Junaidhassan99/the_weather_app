using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_weather_app
{
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
}
