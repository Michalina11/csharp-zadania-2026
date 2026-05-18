using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace JsonSerializationApp
{
    public class ProductManager
    {
        public void SaveProducts(List<Product> products, string path)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(products, options);

            File.WriteAllText(path, json);
        }

        public List<Product> LoadProducts(string path)
        {
            if (!File.Exists(path))
            {
                return new List<Product>();
            }

            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<List<Product>>(json);
        }
    }
}
