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




            Console.WriteLine(GeneralUtilities.getJsonStringResponse("https://www.googleapis.com/books/v1/volumes/s1gVAAAAYAAJ"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form Loaded");
        }
    }

    public class GeneralUtilities
    {
        public static string getJsonStringResponse(string urlString)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(urlString));

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
    }

    
}
