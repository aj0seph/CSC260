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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WeatherProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateButtons = new List<WeatherDisplayButton>();
        }
        
        string APIKey = "3ca07f675106a4fe2253d8f853feb77a";
        private List<WeatherDisplayButton> UpdateButtons;

        public void AddNewButton(WeatherDisplayButton button) 
        {
            //this = new Object();
            UpdateButtons.Add(button);
        
        }

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
                ConditionResponse.Text = Info.weather[0].main;
                DetailsResponse.Text = Info.weather[0].description;
                SunriseResponse.Text = Info.sys.sunrise.ToString();
                SunsetResponse.Text = Info.sys.sunset.ToString();
                WindSpeedResponse.Text = Info.wind.speed.ToString();
                PressureResponse.Text = Info.main.pressure.ToString();
                //Currently in Kelvin, change to Fahrenheit
                double kelvinTemp = Info.main.temp;
                double fahrenheitTemp = (kelvinTemp - 273.15) * 1.8 + 32;
                TempResponse.Text = fahrenheitTemp.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        

        private void TxtCityState_TextChanged(object sender, EventArgs e)
        {       //trying to achieve that greyed text in search-box?
                if (TxtCityState.Text == "Enter your city or state here...")
                {
                TxtCityState.Text = "";
                }
            }

        //Gives us just the day of the week
        private void Date_Click(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("dddd");
        }
    }
    }

