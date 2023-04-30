using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    internal class PressureDisplayButton : WeatherDisplayButton, WeatherDisplayInterface
    {


        public void GetDisplayText(WeatherInfo.root jsonObject)
        {
            this.Text = jsonObject.main.pressure.ToString();
        }
    }
}
