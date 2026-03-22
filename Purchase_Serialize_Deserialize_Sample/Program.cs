using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BE;
using BLL;

namespace Purchase_Serialize_Deserialize_Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var bllProduct = new BLLProduct();

                var customer = new Customer
                {
                    IDNumber = 12345678,
                    FirstName = "John",
                    LastName = "Doe",
                    MaritalStatus = MaritalStatus.Single,
                    BirthDate = new DateTime(1999, 5, 15, 0, 0, 0, DateTimeKind.Utc),
                    FullAddress = "123 Main St, Anytown, USA"
                };

                var products = bllProduct.GetAll();

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
