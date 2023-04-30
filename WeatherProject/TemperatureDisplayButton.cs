using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    internal class TemperatureDisplayButton : WeatherDisplayButton, WeatherDisplayInterface
    {
        public TemperatureDisplayButton()
        
        {
        }

        public void GetDisplayText(WeatherInfo.root jsonObject)
        {
            double kelvinTemp = jsonObject.main.temp;
            double fahrenheitTemp = (kelvinTemp - 273.15) * 1.8 + 32;
            this.Text = fahrenheitTemp.ToString();
        }

    }
}
