using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    internal class ConditionDisplayButton : WeatherDisplayButton, WeatherDisplayInterface
    {
        public void GetDisplayText(WeatherInfo.root jsonObject)
        {
            this.Text = jsonObject.weather[0].main;

        }
        
    }
}
