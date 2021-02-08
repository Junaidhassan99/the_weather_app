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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Form initialized");

            try
            {
                textBox1.Text = ApiUtilities.getWeatherByCityName("paris");
            }
            catch (Exception  exception)
            {
                Console.WriteLine(exception);
                textBox1.Text = "Invalid City";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form Loaded");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class ApiUtilities
    {
        public static string getJsonStringResponse(string urlString)
        {
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

            //List<Item> items = JsonConvert.DeserializeObject<List<Item>>(jsonString);

            return jsonString;

        }

        public static string getWeatherByCityName(string cityName)
        {
            string urlString = Credentials.initialApiSearchByCity + "?q=" + cityName + "&appid=" + Credentials.apiKey;
            return ApiUtilities.getJsonStringResponse(urlString);
        }

    }

    public class Credentials
    {
        //open weather service is being used
        public static string apiKey = "9c0a03a6202a00f30ffdb380c085ec83";
        public static string initialApiSearchByCity = "https://api.openweathermap.org/data/2.5/weather";

    }
}
