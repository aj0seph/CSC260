using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherProject
{
    public abstract class WeatherDisplayButton : System.Windows.Forms.Button
    {

        public WeatherDisplayButton(Form1 parent) 
        {
            
            parent.AddNewButton(this);  
        
        }

        public abstract string GetDisplayText(WeatherInfo.root jsonObject);



    }
}
