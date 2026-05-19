using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace WeatherApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Weather Api CLient ===");

                Console.Write("Podaj miasto (lub exit): ");

                string city = Console.ReadLine();

                if (city.ToLower() == "exit")
                {
                    break;
                }

                string url = $"https://wtrr.in/{city}?format=j1";

                try
                {
                    using HttpClient client = new HttpClient();

                    string json = await client.GetStringAsync(url);

                    WeatherResponse response = JsonSerializer.Deserialize<WeatherResponse>(json);

                    CurrentCondition current = response.CurrentCondition[0];

                    Console.WriteLine("\n=== POGODA ===");

                    Console.WriteLine($"Miasto: {city}");
                    Console.WriteLine($"Temperatura: {current.TempC}");
                    Console.WriteLine($"Opis: {current.WeatherDesc[0].Value}");
                    Console.WriteLine($"Wiatr: {current.WindSpeedKmph} km/h");
                    Console.WriteLine($"Wilgotność: {current.Humidity}%");
                }

                catch (HttpRequestException)
                {
                    Console.WriteLine("Błąd połączenia z API.");
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }
        }
    }
}
