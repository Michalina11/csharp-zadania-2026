using System;
using System.Collections.Generic;

namespace JsonSerializationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            ProductManager manager = new ProductManager();

            string path = "products.json";

            while (true)
            {
                Console.WriteLine("\n===PRODUCT MANAGER ===");
                Console.WriteLine("[1] Dodaj produkt");
                Console.WriteLine("[2] Zapisz do JSON");
                Console.WriteLine("[3] Wczytaj z JSON");
                Console.WriteLine("[4] WYświetl produkty");
                Console.WriteLine("[0] Wyjdź");

                Console.Write("Wybierz opcję: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Product product = new Product();

                        Console.Write("ID: ");
                        product.Id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nazwa: ");
                        product.Name = Console.ReadLine();

                        Console.Write("Cena: ");
                        product.Price = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Kategoria: ");
                        product.Category = Console.ReadLine();

                        Console.Write("Czy dostępny? (true/false): ");
                        product.InStock = Convert.ToBoolean(Console.ReadLine());

                        products.Add(product);

                        Console.WriteLine("Produkt dodany.");

                        break;

                    case "2":
                        manager.SaveProducts(products, path);

                        Console.WriteLine("Dane zapisane do JSON.");

                        break;

                    case "3":
                        products = manager.LoadProducts(path);

                        Console.WriteLine("Dane wczytane z JSON.");

                        break;

                    case "4":
                        ShowProducts(products);

                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Niepoprawna opcja.");

                        break;
                }
            }
        }

        static void ShowProducts(List<Product> products)
        {
            Console.WriteLine("\n---------------------------------------------------------------");
            Console.WriteLine("| ID | Name         | Price       | Category      | InStock  |");
            Console.WriteLine("---------------------------------------------------------------");

            foreach (Product product in products)
            {
                Console.WriteLine(
                    $"| {product.Id,-2} " +
                    $"| {product.Name,-14} " +
                    $"| {product.Price,-9} " +
                    $"| {product.Category,-12} " +
                    $"| {product.InStock,-7} |"
                );
            }

            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}