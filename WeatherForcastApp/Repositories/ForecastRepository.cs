using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForecastApp.OpenWeatherMapModels;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Net.Http;
//using System.Activities.Tracking;


namespace ForecastApp.Repositories
{
    public class ForecastRepository : IForecastRepository
    {
        WeatherResponse IForecastRepository.GetForecast(string city)
        {
            string IDOWeather = Constants.OPEN_WEATHER_APPID;
           
            var client = new HttpClient();
            var weatherURL = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={IDOWeather}";

            var response2 = new WeatherResponse();

           
            try
            { 
            var response = client.GetStringAsync(weatherURL).Result;
      
                // Deserialize the string content into JToken object
                var content = JsonConvert.DeserializeObject<WeatherResponse>(response);

                // Deserialize the JToken object into our WeatherResponse Class
                return content;
            }
            catch { return null; }

            
        }
    }
}
