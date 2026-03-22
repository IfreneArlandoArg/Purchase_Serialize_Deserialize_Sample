using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DALProduct : IRepository<Product>
    {
        public void Add(Product item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return new List<Product>
                {
                  new Product { IdProduct = 0,  Name = "Wireless Mouse", Price = 29.99m },
                  new Product { IdProduct = 1, Name = "Mechanical Keyboard", Price = 89.95m },
                  new Product { IdProduct = 2, Name = "USB-C Hub", Price = 39.50m },
                  new Product { IdProduct = 3, Name = "27-inch Monitor", Price = 249.99m },
                  new Product { IdProduct = 4, Name = "Laptop Stand", Price = 45.00m },
                  new Product { IdProduct = 5, Name = "Noise-Cancelling Headphones", Price = 199.99m },
                  new Product { IdProduct = 6, Name = "Webcam 1080p", Price = 59.99m },
                  new Product { IdProduct = 7,  Name = "External SSD 1TB", Price = 129.99m },
                  new Product { IdProduct = 8, Name = "Portable Charger 10000mAh", Price = 34.95m },
                  new Product { IdProduct = 9, Name = "Smartphone Case", Price = 19.99m },
                  new Product { IdProduct = 10, Name = "Bluetooth Speaker", Price = 79.99m },
                  new Product { IdProduct = 11, Name = "Ethernet Cable (10ft)", Price = 9.99m }
                };
        }

        

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
