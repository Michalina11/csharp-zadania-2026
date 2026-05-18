using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace JsonSerializationApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public bool InStock { get; set; }   
    }
}
