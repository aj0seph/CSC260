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
using static System.Windows.Forms.AxHost;
using System.Windows.Forms.VisualStyles;
using System.Net.NetworkInformation;

namespace WeatherProject
{

    public partial class Form1 : Form
    {

        private List<string> validStates = new List<string> {
        "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado",
        "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho",
        "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine",
        "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi",
        "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey",
        "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio",
        "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina",
        "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia",
        "Washington", "West Virginia", "Wisconsin", "Wyoming"
    };
        private List<string> validCountries = new List<string> {
        "United States", "Canada", "Mexico"
    };

        public Form1()
        {
            InitializeComponent();

            UpdateButtons = new List<WeatherDisplayInterface>();
            this.AddNewButton(this.SunsetResponse);
            this.AddNewButton(this.SunriseResponse);
            this.AddNewButton(this.WindSpeedResponse);
            this.AddNewButton(this.PressureResponse);
            this.AddNewButton(this.TempResponse);
            this.AddNewButton(this.ConditionResponse);
            this.AddNewButton(this.DetailsResponse);

            Date_Click();
            TxtCityState.Text = "Enter your city or state here...";
            SetAutoCompleteTextBox(TxtCityState);
        }
        
        string APIKey = "3ca07f675106a4fe2253d8f853feb77a";
        private List<WeatherDisplayInterface> UpdateButtons;

        public void AddNewButton(WeatherDisplayInterface button) 
        {
            //this = new Object();
            UpdateButtons.Add(button);
        
        }

        //search btn
        private void button1_Click(object sender, EventArgs e)
        {
            string state = TxtCityState.Text;
            string country = TxtCityState.Text;

            if (!validStates.Contains(state) || !validCountries.Contains(country))
            {
                MessageBox.Show("Please enter a valid state or country.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                getWeather();
            }
            //MessageBox.Show(TxtCityState.Text);


        }
        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TxtCityState.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                for(int i = 0;  i < UpdateButtons.Count; ++i) 
                {
                    WeatherDisplayInterface curbutton = UpdateButtons[i];
                    curbutton.GetDisplayText(Info);

                }

                
                

            }
        }
        //not sure about this:
        private void SetAutoCompleteTextBox(System.Windows.Forms.TextBox TxtCityState) 
        {
        
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(new string[] { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" });
            TxtCityState.AutoCompleteCustomSource = source;
            TxtCityState.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TxtCityState.AutoCompleteSource = AutoCompleteSource.CustomSource;

        
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void TxtCityState_Click(object sender, EventArgs e)
        {       //trying to achieve that greyed text in search-box?

            TxtCityState.Text = "";


    }
        private void Date_Click()
        {
            string dayName = DateTime.Now.ToString("dddd");
            string date = DateTime.Now.ToString("MMMM dd");

            Date.Text = "Hello! Today is, " + dayName + " " + date;
        }
        //Gives us just the day of the week


        public static DateTime convertDateTime(long unixTimestamp) 
        {
            /*
            DateTime day = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddMilliseconds(milisec).ToLocalTime();
            */

            DateTimeOffset offset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
            DateTime result = offset.LocalDateTime;
            return result;
        }

        private void TxtCityState_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

