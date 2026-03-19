using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using BE;




namespace Purchase_Deserialize
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Very important to use the same path where the file was created, otherwise it will throw an exception because it won't find the file...
                //Tip: First Run (CTRL+F5) Purchse_Serialize project and copy the file path from the terminal, then paste it here in the code and use it to read the file.
                //                                       Modify Me....
                //                                    ⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️
                var purchaseJson = File.ReadAllText("C:\\Users\\Sample.json");

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
