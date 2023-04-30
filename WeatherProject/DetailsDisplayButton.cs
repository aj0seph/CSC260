using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    internal class DetailsDisplayButton : WeatherDisplayButton, WeatherDisplayInterface
    {

        public void GetDisplayText(WeatherInfo.root jsonObject)
        {
            this.Text = jsonObject.weather[0].description;
        }
    }
}
