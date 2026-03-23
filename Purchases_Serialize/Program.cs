using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using BE;
using BLL;

namespace Purchases_Serialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var bllProduct = new BLLProduct();
                var bllCustomer = new BLLCustomer();
                var bllPurchase = new BLLPurchase();



                var customer = bllCustomer.GetById(87654321);

                var products = bllProduct.GetAll().Where(P => P.Price > 20).ToList();

                var purchase = new Purchase(customer, products);


                var purchases = bllPurchase.GetAll();

                purchases.Add(purchase);

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                var json = JsonSerializer.Serialize(purchases, options);


                

                var DesktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var MainDirectory = Path.Combine(DesktopDirectory, "Purchases");


                if (Directory.Exists(MainDirectory))
                {
                    Directory.CreateDirectory(MainDirectory);
                }



                var fullPath = Path.Combine(MainDirectory, "Purchases.json");


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
