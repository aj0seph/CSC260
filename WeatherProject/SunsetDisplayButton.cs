using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    internal class SunsetDisplayButton : WeatherDisplayButton, WeatherDisplayInterface
    {
    
     

        public void GetDisplayText(WeatherInfo.root jsonObject)
        {
           this.Text = Form1.convertDateTime(jsonObject.sys.sunset, jsonObject.timezone).ToString("hh:mm:tt");
        }
    }
    }
