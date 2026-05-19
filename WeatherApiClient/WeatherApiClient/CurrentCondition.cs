using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeatherApiClient
{
    public class CurrentCondition
    {
        [JsonPropertyName("temp_C")]
        public string TempC {  get; set; }

        [JsonPropertyName("windspeedKmph")]
        public string WindSpeedKmph { get; set; }

        [JsonPropertyName("Humidity")]
        public string Humidity { get; set; }

        [JsonPropertyName("weatherDesc")]
        public List<WeatherDescription> WeatherDesc { get; set; }
    }
}
