using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace the_weather_app
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Console.WriteLine("Form initialized");

            try
            {
                //find current location and set data here

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                //textBox1.Text = "Invalid City";
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Home Loaded");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchTextBoxString;
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchTextBoxString = searchTextBox.Text;
                setCurrentWeatherData(searchTextBoxString);
                setForecasteWeatherData(searchTextBoxString);
            }
        }

        private void setCurrentWeatherData(string cityName)
        {
            CurrentWeather currentWeather = ApiUtilities.getCurrentWeatherByCityName(cityName);
            cityLable.Text = currentWeather.CityName + ", " + currentWeather.Country;
            tempLabel.Text = "Temperature : " + ApiUtilities.convertKelvenToCelcius(currentWeather.Temp) + "°";
            feelsLikeLabel.Text = "Feels Like : " + ApiUtilities.convertKelvenToCelcius(currentWeather.FeelsLike) + "°";
            pressureLabel.Text = "Pressure : " + currentWeather.Pressure + " hPa";
            humidityLabel.Text = "Humidity : " + currentWeather.Humidity + " %";
            windLabel.Text = "Wind : " + currentWeather.WindSpeed + " ms, " + currentWeather.WindDirection + "°";
            cloudCoverLabel.Text = "Cloud Cover : " + currentWeather.CloudCover + " %";
            currentWeatherIconImage.ImageLocation = ApiUtilities.getImageUrl(currentWeather.ImageIcon);



        }

        private void setForecasteWeatherData(string cityName)
        {
            List<ForecastWeather> forecastWeatherList = ApiUtilities.getForecastWeatherByCityName(cityName);

            foreach (ForecastWeather forecastWeatherElement in forecastWeatherList)
            {
                Console.WriteLine("test : {0}", forecastWeatherElement.DateText);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }





}
