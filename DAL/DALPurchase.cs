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

        void HandleEmptyDirectory(string MainDirectory, string FilePath) 
        {
            if (!Directory.Exists(MainDirectory))
            {
                Directory.CreateDirectory(MainDirectory);
            }

            var OptionsWrite = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(new List<Purchase>(), OptionsWrite);

            File.WriteAllText(FilePath, json);
        }

        public List<Purchase> GetAll()
        {
            var DesktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var MainDirectory = Path.Combine(DesktopDirectory, "Purchases");
            var FilePath = Path.Combine(MainDirectory, "Purchases.json");



            if (!File.Exists(FilePath))
            {
                HandleEmptyDirectory(MainDirectory, FilePath);
            }


            var purchasesJson = File.ReadAllText($@"{FilePath}");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IncludeFields = true
            };


            return JsonSerializer.Deserialize<List<Purchase>>(purchasesJson, options);


            
        }
    }
}