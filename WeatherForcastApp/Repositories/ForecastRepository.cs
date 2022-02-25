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
           // public string IDOMaps = Constants.mapsApiKey;

            // Connection String
            //var client = new RestClient($"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&APPID={IDOWeather}");
            //var request = new RestRequest(Method.GET);
            //IRestResponse response = client.Execute(request);
            var client = new HttpClient();
            var weatherURL = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={IDOWeather}";

            var response2 = new WeatherResponse();
            //string IDOMaps = Constants.mapsApiKey;
            
           //response2.MapsURL = $"https://www.google.com/maps/embed/v1/place?key={IDOMaps}&q={city}";
            try
            { 
            var response = client.GetStringAsync(weatherURL).Result;



           
            
                // Deserialize the string content into JToken object
                var content = JsonConvert.DeserializeObject<JToken>(response);

                // Deserialize the JToken object into our WeatherResponse Class
                return content.ToObject<WeatherResponse>();
            }
            catch { return null; }

            
        }
    }
}
