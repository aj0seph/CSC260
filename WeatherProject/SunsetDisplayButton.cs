using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    internal class SunsetDisplayButton : WeatherDisplayButton
    {
    
        public SunsetDisplayButton(Form1 parent)
            : base(parent)
        {
        }

        public override string GetDisplayText(WeatherInfo.root jsonObject)
        {
            return jsonObject.sys.sunset.ToString();
        }
    }
}
