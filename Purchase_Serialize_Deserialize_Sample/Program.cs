
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

            var customer = new Customer(12345678, "John", "Doe", MaritalStatus.Single, new DateTime(1998, 1, 9), "123 Main St, Anytown, USA");

            Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}, Age: {customer.GetAge()}, Marital Status: {customer.MaritalStatus}, Address: {customer.FullAddress}");

            //var customers = new List<Customer>
            //{
            //    new Customer(12345678, "John", "Doe", MaritalStatus.Single, new DateTime(1999, 5, 15), "123 Main St, Anytown, USA"),
            //    new Customer(87654321, "Jane", "Smith", MaritalStatus.Married, new DateTime(1985, 10, 20), "456 Elm St, Othertown, USA"),
            //    new Customer(11223344, "Alice", "Johnson", MaritalStatus.Divorced, new DateTime(2006, 3, 30), "789 Oak St, Sometown, USA"),
            //    new Customer(44332211, "Bob", "Brown", MaritalStatus.Widowed, new DateTime(2005, 7, 5), "321 Pine St, Anycity, USA"),
            //    new Customer(55667788, "Charlie", "Davis", MaritalStatus.Single, new DateTime(1990, 12, 25), "654 Maple St, Othercity, USA")

            //};

            //var products = new List<Product>
            //{
            //    new Product { Name = "Wireless Mouse", Price = 29.99m },
            //    new Product { Name = "Mechanical Keyboard", Price = 89.95m },
            //    new Product { Name = "USB-C Hub", Price = 39.50m },
            //    new Product { Name = "27-inch Monitor", Price = 249.99m },
            //    new Product { Name = "Laptop Stand", Price = 45.00m },
            //    new Product { Name = "Noise-Cancelling Headphones", Price = 199.99m },
            //    new Product { Name = "Webcam 1080p", Price = 59.99m },
            //    new Product { Name = "External SSD 1TB", Price = 129.99m },
            //    new Product { Name = "Portable Charger 10000mAh", Price = 34.95m },
            //    new Product { Name = "Smartphone Case", Price = 19.99m },
            //    new Product { Name = "Bluetooth Speaker", Price = 79.99m },
            //    new Product { Name = "Ethernet Cable (10ft)", Price = 9.99m }
            //};

            //var purchase = new Purchase(products);
            
            //var options = new  JsonSerializerOptions
            //{
            //    WriteIndented = true
            //};

            //var json = JsonSerializer.Serialize(purchase,options);

            

            //var fileName = $"purchase{purchase.IdPurchase}.json";

            //var fullPath = Path.GetFullPath(fileName);

            //File.WriteAllText(fullPath, json);

            //Console.WriteLine($"Serialized JSON: \n{json}");

            //Console.WriteLine($"Serialized JSON: \n{json}");
            //Console.WriteLine($"\nFile path:\n{fullPath}");
           

        }
    }
}
