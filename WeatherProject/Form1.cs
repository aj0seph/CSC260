using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = "3ca07f675106a4fe2253d8f853feb77a";

        private void button1_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TxtCityState.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                TxtCondition.Text = Info.weather[0].main;
                TxtDetails.Text = Info.weather[0].description;
                SunriseResponse.Text = Info.sys.sunrise.ToString();
                SunsetResponse.Text = Info.sys.sunset.ToString();
                WindSpeedResponse.Text = Info.wind.speed.ToString();
                PressureResponse.Text = Info.main.pressure.ToString();

            }



        }

    }
}
