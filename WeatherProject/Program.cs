using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace WeatherProject
{
    internal static class Program
    {
        static string getStringFromUrl(HttpClient client, string url)
        {
            var asyncResult = client.GetStringAsync(url);
            asyncResult.Wait();
            return asyncResult.Result;
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HttpClient client = new HttpClient();
            //client.GetStringAsync("https://api.weatherbit.io/v2.0/current?lat=35.7796&lon=-78.6382&key=38369a3a213f4172a8d26a15284ddbc1&include=minutely");
            //client.getStringFromUrl("https://api.weatherbit.io/v2.0/current?lat=35.7796&lon=-78.6382&key=38369a3a213f4172a8d26a15284ddbc1&include=minutely");
            string httpResult = getStringFromUrl(client, "https://api.weatherbit.io/v2.0/current?lat=35.7796&lon=-78.6382&key=38369a3a213f4172a8d26a15284ddbc1&include=minutely");
            WeatherInfo.root convertedResult = JsonConvert.DeserializeObject<WeatherInfo.root>(httpResult);
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
