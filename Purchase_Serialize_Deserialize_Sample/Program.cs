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
            try
            {
                
                var customer = new Customer
                {
                    IDNumber = 12345678,
                    FirstName = "John",
                    LastName = "Doe",
                    MaritalStatus = MaritalStatus.Single,
                    BirthDate = new DateTime(1999, 5, 15, 0, 0, 0, DateTimeKind.Utc),
                    FullAddress = "123 Main St, Anytown, USA"
                };

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

                var purchase = new Purchase(customer, products);

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                var json = JsonSerializer.Serialize(purchase, options);


                var DesktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var MainDirectory = Path.Combine(DesktopDirectory, "Purchases");


                if (!Directory.Exists(MainDirectory))
                {
                    Directory.CreateDirectory(MainDirectory);
                }



                var fullPath = Path.Combine(MainDirectory, $"purchase{purchase.IdPurchase}.json");


                File.WriteAllText(fullPath, json);


                Console.WriteLine($"Serialized JSON: \n{json}");
                Console.WriteLine($"\nFile path:\n{fullPath}");
            
            }
            catch (Exception Ex)
            {

                Console.WriteLine(Ex.Message);
            }
            


        }
    }
}
