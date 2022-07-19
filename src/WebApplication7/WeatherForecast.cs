using System;

namespace WebApplication7
{
    /// <summary>objeto de temperatura</summary>
    public class WeatherForecast
    {
        /// <summary>Data de quando a temperatura se refere</summary>
        public DateTime Date { get; set; }

        /// <summary>temperatura em Celsius</summary>
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
