using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    public class WeatherInfo
    {

        public class coord 
        {
            public double lon { get; set; }
            public double lat { get; set; }
       
        }

        public class weather 
        {
                public string main { get; set; }

                public string description { get; set; }
                public string icon { get; set; }
        }
        public class main 
        {
            public double temp { get; set; }
            public double pressure { get; set; }     
            public double humidity { get; set; }
        
        }
        public class wind 
        {
            public double speed { get; set; }   
        
        }

        public class sys 
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }
        
        }

        public class root 
        {
            public coord coord { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }

            public wind wind { get; set; }

            public sys sys { get; set; }


        }

        }

        /*public class data 
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
        */
}
