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
            this.Text = "The Weather";

            //groupBox2.Left = (this.ClientSize.Width - groupBox2.Width) / 2;
            //Console.WriteLine("change resolution");
            //groupBox2.Top = (this.ClientSize.Height - groupBox2.Height) / 2;

            //find current location and set data here

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
                try
                {

                    searchTextBoxString = searchTextBox.Text;
                    setCurrentWeatherData(searchTextBoxString);
                    setForecasteWeatherData(searchTextBoxString);

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    errorMessageBox();
                }

            }
        }

        private void setCurrentWeatherData(string cityName)
        {
            CurrentWeather currentWeather = ApiUtilities.getCurrentWeatherByCityName(cityName);

            labelDateTime.Text = DisplayTextDataUtility.displayCurrentDateText();
            cityLable.Text = DisplayTextDataUtility.displayCity(currentWeather.CityName, currentWeather.Country);
            tempLabel.Text = DisplayTextDataUtility.displayTemp(ApiUtilities.convertKelvenToCelcius(currentWeather.Temp));
            feelsLikeLabel.Text = DisplayTextDataUtility.displayFeelsLike(ApiUtilities.convertKelvenToCelcius(currentWeather.FeelsLike));
            pressureLabel.Text = DisplayTextDataUtility.displayPressure(currentWeather.Pressure);
            humidityLabel.Text = DisplayTextDataUtility.displayhumidity(currentWeather.Humidity);
            windLabel.Text = DisplayTextDataUtility.displaywind(currentWeather.WindSpeed, currentWeather.WindDirection);
            cloudCoverLabel.Text = DisplayTextDataUtility.displayCloudCover(currentWeather.CloudCover);
            currentWeatherIconImage.ImageLocation = ApiUtilities.getImageUrl(currentWeather.ImageIcon);
        }

        private void setForecasteWeatherData(string cityName)
        {
            List<ForecastWeather> forecastWeatherList = ApiUtilities.getForecastWeatherByCityName(cityName);

            //ListView ListView = new ListView();

            //foreach (ForecastWeather forecastWeatherElement in forecastWeatherList)
            for (int i = 0; i < forecastWeatherList.Count; i++)
            {
                ForecastWeather forecastWeatherElement = forecastWeatherList[i];

                Console.WriteLine("test : {0}", forecastWeatherElement.DateText);

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();

                //row.Cells["ColumnDateText"].Value = forecastWeatherElement.DateText;
                row.Cells[0].Value = DisplayTextDataUtility.displayDateText(forecastWeatherElement.DateText);
                row.Cells[1].Value = DisplayTextDataUtility.displayTemp(forecastWeatherElement.Temp);
                row.Cells[2].Value = DisplayTextDataUtility.displayFeelsLike(ApiUtilities.convertKelvenToCelcius(forecastWeatherElement.FeelsLike));
                row.Cells[3].Value = DisplayTextDataUtility.displayhumidity(forecastWeatherElement.Humidity);
                row.Cells[4].Value = DisplayTextDataUtility.displayPressure(forecastWeatherElement.Pressure);
                row.Cells[5].Value = DisplayTextDataUtility.displaywind(forecastWeatherElement.WindSpeed, forecastWeatherElement.WindDirection);
                row.Cells[6].Value = DisplayTextDataUtility.displayCloudCover(forecastWeatherElement.CloudCover);

                dataGridView1.Rows.Add(row);


            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void errorMessageBox()
        {
            string message = "Invalid city entered!";
            string title = "Alert";
            MessageBox.Show(message, title);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("help was pressed");

            HelpForm helpForm = new HelpForm();
            helpForm.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.Show();
            //this.Hide();
        }
    }





}
