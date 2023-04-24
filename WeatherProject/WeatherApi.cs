using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WeatherProject
{
    internal class WeatherApi
    {
        //public class 
        /*
        public class WeatherInfo
        {
            public float app_temp { get; set; }
        }
        */

        
        public class WeatherInfo 
        {
            public float app_temp { get; set;}
            public int aqi { get; set; }
            public string city_name { get; set; }
            public int clouds { get; set; }
            public string country_code { get; set; }
            public string datetime { get; set;}
            public double dewpt { get; set; }
            public double dhi { get; set; }
            public double dni { get; set; }
            public double elev_angle { get; set; }
            public double ghi { get; set; }
            public string gust { get; set; }
            public double h_angle { get; set; }
            public double lat { get; set; }
            public double lon { get; set; }
            public string ob_time { get; set; }
            public string pod { get; set; }
            public int precip { get; set; }
            public double pres { get; set; }
            public int rh { get; set; }
            public double slp { get; set; }
            public int snow { get; set; }
            public double solar_rad { get; set; }
            public string[] sources {get; set; }
            public weather weather { get; set; }
        }
        

        public class weather
        {
            public string icon { get; set; }
            public string description { get; set; }
            public int code{ get; set; }
        }
        //attributes of the classes
        //contains everything we've created above
        public class container
        {
            public int count { get; set; }
            //public WeatherInfo[] data { get; set; }
            public List<WeatherInfo> data { get; set; }
            //public List <weather> weather { get; set;} 
        }

    }
}
