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
                searchTextBoxString=searchTextBox.Text;
                setCurrentWeatherData(searchTextBoxString);
            }
        }

        private void setCurrentWeatherData(string cityName)
        {
            CurrentWeather currentWeather = ApiUtilities.getWeatherByCityName(cityName);
            cityLable.Text = "City : " + currentWeather.CityName;
            coordLabel.Text = "Coordinates : " + currentWeather.Coordinate;
            tempLabel.Text = "Temperature : " + currentWeather.Temp;
        }
    }





}
