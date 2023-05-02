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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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
            "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Anguilla", 
            "Antigua & Barbuda", "Argentina", "Armenia", "Australia", "Austria", 
            "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", 
            "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia & Herzegovina", 
            "Botswana", "Brazil", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", 
            "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", 
            "Central African Republic", "Chad", "Chile", "China", "China - Hong Kong / Macau", 
            "Colombia", "Comoros", "Congo", "Congo, Democratic Republic of (DRC)", 
            "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", 
            "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", 
            "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", 
            "Ethiopia", "Fiji", "Finland", "France", "French Guiana", "Gabon", 
            "Gambia, Republic of The", "Georgia", "Germany", "Ghana", "Great Britain", 
            "Greece", "Grenada", "Guadeloupe", "Guatemala", "Guinea", "Guinea-Bissau", 
            "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", 
            "Iran", "Iraq", "Israel and the Occupied Territories", "Italy", 
            "Ivory Coast (Cote d'Ivoire)", "Jamaica", "Japan", "Jordan", 
            "Kazakhstan", "Kenya", "Korea, Democratic Republic of (North Korea)", 
            "Korea, Republic of (South Korea)", "Kosovo", "Kuwait", 
            "Kyrgyz Republic (Kyrgyzstan)", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", 
            "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", 
            "Malaysia", "Maldives", "Mali", "Malta", "Martinique", "Mauritania", 
            "Mauritius", "Mayotte", "Mexico", "Moldova, Republic of", 
            "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco", 
            "Mozambique", "Myanmar/Burma", "Namibia", "Nepal", "Netherlands", 
            "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia, Republic of", 
            "Norway", "Oman", "Pacific Islands", "Pakistan", "Panama", "Papua New Guinea", 
            "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", 
            "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Kitts and Nevis", 
            "Saint Lucia", "Tajikistan", "Tanzania", "Thailand", 
            "Timor Leste", "Togo", "Trinidad & Tobago", "Tunisia", "Türkiye (Turkey)", 
            "Turkmenistan", "Turks & Caicos Islands", "Uganda", "Ukraine", 
            "United Arab Emirates", "United States of America (USA)", "Uruguay", 
            "Uzbekistan", "Venezuela", "Vietnam", "Virgin Islands (UK)", 
            "Virgin Islands (US)", "Yemen", "Zambia", "Zimbabwe"
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
            //TxtCityState.Text = "Enter your city or state here...";
            SetAutoCompleteTextBox(TxtCityState);
        }
        string APIKey = "a5b9fe29e8421e2112e56171f6371b89";
        //string APIKey = "3ca07f675106a4fe2253d8f853feb77a";
        private List<WeatherDisplayInterface> UpdateButtons;
        public void AddNewButton(WeatherDisplayInterface button)
        {
            //this = new Object();
            UpdateButtons.Add(button);
        }

        //search btn
        private void button1_Click(object sender, EventArgs e)
        {
            string state = TxtCityState.Text.ToLower();
            string country = TxtCityState.Text.ToLower();
            if (!validStates.Select(oneStr => oneStr.ToLower()).Contains(state)
            && !validCountries.Select(oneStr => oneStr.ToLower()).Contains(country))
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
        private void SetAutoCompleteTextBox(System.Windows.Forms.TextBox unusedParam)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(new string[] { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" });
            TxtCityState.AutoCompleteCustomSource = source;
            TxtCityState.AutoCompleteMode = AutoCompleteMode.Suggest;
            TxtCityState.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void TxtCityState_Click(object sender, EventArgs e)
        {       //trying to achieve that greyed text in search-box?

            //TxtCityState.Text = "";


    }
        private void Date_Click()
        {
            string dayName = DateTime.Now.ToString("dddd");
            string date = DateTime.Now.ToString("MMMM dd");

            Date.Text = "Hello! Today is, " + dayName + " " + date;
        }
        //Gives us just the day of the week


        public static DateTime convertDateTime(long unixTimestamp, int timezoneSecondsOffset) 
        {


            DateTimeOffset offset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
            DateTime result = offset.UtcDateTime.AddSeconds(timezoneSecondsOffset);

            return result;
        }

        private void TxtCityState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)Keys.Enter)
            {
                //Call the code that handles the search
                getWeather();

                //prevent the key press from being processed further
                e.Handled = true;
            
            }
        }
    }
    }

