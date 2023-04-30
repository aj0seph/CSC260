using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    public sealed class SunriseDisplayButton  : WeatherDisplayButton, WeatherDisplayInterface
    {
        //this will be how all the constructors for all of the classes that derive from WeatherDisplayButton will look

        public void GetDisplayText(WeatherInfo.root jsonObject)
        {
            this.Text = Form1.convertDateTime(jsonObject.sys.sunrise).ToString("hh:mm:tt");
        }                      
    }
}
