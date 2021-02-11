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
                //textBox1.Text = ApiUtilities.getWeatherByCityName("paris");
                CurrentWeather currentWeather= ApiUtilities.getWeatherByCityName("paris");
                cityLable.Text ="City : "+ currentWeather.CityName;
                coordLabel.Text = "Coordinates : " + currentWeather.Coordinate;
                tempLabel.Text = "Temperature : " + currentWeather.Temp;
            }
            catch (Exception  exception)
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
    }

    
    

    
}
