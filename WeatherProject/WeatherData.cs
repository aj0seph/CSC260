using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    internal class WeatherData
    {
        public class data 
        {
            double app_temp { get; set;}
            double aqi { get; set; }
            string city_name { get; set; }
            int clouds { get; set; }
            string country_code { get; set; }
            string datetime { get; set;}
            double dewpt { get; set; }
            double dhi { get; set; }
            double dni { get; set; }
            double elev_angle { get; set; }
            double ghi { get; set; }
            string gust { get; set; }
            double h_angle { get; set; }
            double lat { get; set; }
            double lon { get; set; }
            string ob_time { get; set; }
            string pod { get; set; }
            int precip { get; set; }
            double pres { get; set; }
            int rh { get; set; }
            double slp { get; set; }
            int snow { get; set; }
            double solar_rad { get; set; }
//not sure about sources..
            string sources { get; set; }
        }

        public class weather
        {
            string icon { get; set; }

            string description { get; set; }
            string code{ get; set; }
        }
        //attributes of the classes
        //contains everything we've created above
        public class container
        {
            public data data { get; set; }
            public List <weather> weather { get; set;} 
        }

    }
}
