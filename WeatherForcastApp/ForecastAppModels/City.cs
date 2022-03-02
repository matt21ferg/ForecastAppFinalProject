﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace WeatherForcastApp.ForecastAppModels
{
    public class City
    {
        [Display(Name = "City:")]
        public string Name { get; set; }

        [Display(Name = "Temperature:")]
        public float Temp { get; set; }

        [Display(Name = "Humidity")]
        public int Humidity { get; set; }

        [Display(Name = "Pressure:")]
        public int Pressure { get; set; }

        [Display(Name = "Wind Speed:")]
        public float Wind { get; set; }

        [Display(Name = "Weather Condition:")]
        public string Weather { get; set; }

        public string Icon { get; set; }
        public string ImagePath
        {
            get
            {
                return $"http://openweathermap.org/img/wn/{Icon}@2x.png";
            }
        }



        public double lon { get; set; }

        public double lat { get; set; } 

        public string MapsAPIKey { get; set;} = Constants.mapsApiKey;
        
    }



}
