using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    public class SunriseDisplayButton : WeatherDisplayButton
    {
        //this will be how all the constructors for all of the classes that derive from WeatherDisplayButton will look
        public SunriseDisplayButton(Form1 parent)
            : base(parent)
        {
        }

        public override string GetDisplayText(WeatherInfo.root jsonObject)
        {
            return jsonObject.sys.sunrise.ToString();
        }                      
    }
}
