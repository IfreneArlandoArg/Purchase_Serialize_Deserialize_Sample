using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace DAL
{
    public class DALPurchase : IHistoricalRepository<Purchase>
    {
        public void Add(Purchase item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Purchase item)
        {
            throw new NotImplementedException();
        }

        void HandleEmptyDirectory(string MainDirectory) 
        {
            Directory.CreateDirectory(MainDirectory);

            var OptionsWrite = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(new List<Purchase>(), OptionsWrite);

            File.WriteAllText(MainDirectory, json);
        }

        public List<Purchase> GetAll()
        {
            var DesktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var MainDirectory = Path.Combine(DesktopDirectory, "Purchases", "Purchases.json");


            if (Directory.Exists(MainDirectory))
            {
                HandleEmptyDirectory(MainDirectory);
            }





            var purchasesJson = File.ReadAllText($@"{MainDirectory}");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IncludeFields = true
            };



            return JsonSerializer.Deserialize<List<Purchase>>(purchasesJson, options);


            
        }
    }
}