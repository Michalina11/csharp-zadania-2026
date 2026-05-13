using System;
using System.Collections.Generic;

namespace FileLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            while (true)
            {
                Console.WriteLine("\n=== Dziennik Zdarzeń ===");
                Console.WriteLine("[1] Dodaj wpis");
                Console.WriteLine("[2] Szukaj");
                Console.WriteLine("[3] Wyczyść");
                Console.WriteLine("[0] Wyjdź");

                Console.Write("Wybierz opcję: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Podaj treśc wpisu: ");
                        string message = Console.ReadLine();

                        logger.Write(message);

                        Console.WriteLine("Wpis dodany.");
                        break;

                    case "2":
                        Console.Write("Podaj słowo kluczowe: ");
                        string keyword = Console.ReadLine();

                        List<string> results = logger.Search(keyword);

                        Console.WriteLine("\nWyniki wyszukiwania:");

                        if (results.Count == 0)
                        {
                            Console.WriteLine("Brak wyników.");
                        }
                        else
                        {
                            foreach (string line in results)
                            {
                                Console.WriteLine(line);
                            }
                        }

                        break;

                    case "3":
                        logger.Clear();
                        Console.WriteLine("Plik został wyczyszczony.");
                        break;

                    case "0":
                        Console.WriteLine("Koniec programu");
                        return;

                    default:
                        Console.WriteLine("Niepoprawna opcja.");
                        break;
                }
            }
        }
    }
}