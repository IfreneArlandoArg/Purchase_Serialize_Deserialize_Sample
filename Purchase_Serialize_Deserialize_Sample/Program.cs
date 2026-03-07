
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BE;

namespace Purchase_Serialize_Deserialize_Sample
{
    public class Program
    {
        static void Main(string[] args)
        {

            var products = new List<Product>
            {
                new Product { Name = "Wireless Mouse", Price = 29.99m },
                new Product { Name = "Mechanical Keyboard", Price = 89.95m },
                new Product { Name = "USB-C Hub", Price = 39.50m },
                new Product { Name = "27-inch Monitor", Price = 249.99m },
                new Product { Name = "Laptop Stand", Price = 45.00m },
                new Product { Name = "Noise-Cancelling Headphones", Price = 199.99m },
                new Product { Name = "Webcam 1080p", Price = 59.99m },
                new Product { Name = "External SSD 1TB", Price = 129.99m },
                new Product { Name = "Portable Charger 10000mAh", Price = 34.95m },
                new Product { Name = "Smartphone Case", Price = 19.99m },
                new Product { Name = "Bluetooth Speaker", Price = 79.99m },
                new Product { Name = "Ethernet Cable (10ft)", Price = 9.99m }
            };

            var purchase = new Purchase(products);
            
            var options = new  JsonSerializerOptions
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(purchase,options);

            

            var fileName = $"purchase{purchase.IdPurchase}.json";

            var fullPath = Path.GetFullPath(fileName);

            File.WriteAllText(fullPath, json);

            Console.WriteLine($"Serialized JSON: \n{json}");

            Console.WriteLine($"Serialized JSON: \n{json}");
            Console.WriteLine($"\nFile path:\n{fullPath}");
           

        }
    }
}
