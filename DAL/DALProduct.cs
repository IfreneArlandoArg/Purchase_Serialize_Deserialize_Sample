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
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
