using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    internal class DetailsDisplayButton : WeatherDisplayButton
    {
        public DetailsDisplayButton(Form1 parent)
            : base(parent)
        {
        }

        public override string GetDisplayText(WeatherInfo.root[] jsonObject)
        {
            return jsonObject.weather[0].description;
        }
    }
}
