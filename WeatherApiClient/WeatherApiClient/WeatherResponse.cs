using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeatherApiClient
{
    public class WeatherResponse
    {
        [JsonPropertyName("current_condition")]
        public List<CurrentCondition> CurrentCondition { get; set; }
    }
}
