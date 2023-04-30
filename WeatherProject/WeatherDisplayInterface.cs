using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    public interface WeatherDisplayInterface
    {
        void GetDisplayText(WeatherInfo.root jsonObject);
    }
}
