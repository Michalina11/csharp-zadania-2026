using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeatherApiClient
{
    public class WeatherDescription
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
