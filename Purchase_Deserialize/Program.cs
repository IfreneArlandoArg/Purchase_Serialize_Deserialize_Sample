using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;
using BE;




namespace Purchase_Deserialize
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);


                IConfiguration config = builder.Build();

                var purchaseJson = File.ReadAllText($@"{config.GetValue<string>("DeserializeSettings:FilePath")}");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    IncludeFields = true
                };

                

                Purchase purchase = JsonSerializer.Deserialize<Purchase>(purchaseJson, options);

                Console.WriteLine(purchase.ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
           

        }
    }
}
