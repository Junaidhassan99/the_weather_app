using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_weather_app
{
    public class WeatherData
    {
        protected string temp;
        protected string imageIcon;
        protected string feelsLike;
        protected string pressure;
        protected string humidity;
        protected string windSpeed;
        protected string windDirection;
        protected string cloudCover;

        public WeatherData(string temp, string imageIcon, string feelsLike,
            string pressure, string humidity, string windSpeed, string windDirection, string cloudCover         
            )
        {


            this.temp = temp;
            this.imageIcon = imageIcon;
            this.feelsLike = feelsLike;
            this.pressure = pressure;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
            this.windDirection = windDirection;
            this.cloudCover = cloudCover;
            

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
        

    }
}
