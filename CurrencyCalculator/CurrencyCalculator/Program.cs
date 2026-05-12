using System;

namespace CurrencyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Kalkulator Walut ===");

            while (true)
            {
                try
                {
                    Console.Write("\nPodaj kwotę: ");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Z jakiej waluty: ");
                    string from = Console.ReadLine();

                    Console.Write("Na jaką walutę: ");
                    string to = Console.ReadLine();

                    double result = CurrencyConverter.Convert(amount, from, to);

                    Console.WriteLine($"\nWYnik: {Math.Round(result, 2)} {to.ToUpper()}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Podano niepoprawną wartość.");
                }

                Console.Write("\nCzy chcesz wykonać kolejne przeliczenie? (t/n): ");
                string answer = Console.ReadLine().ToLower();

                if (answer == "n")
                {
                    break;
                }
            }

            Console.WriteLine("Koniec programu.");
        }
            
    }
}