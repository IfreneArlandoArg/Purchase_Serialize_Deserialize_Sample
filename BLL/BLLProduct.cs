using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BLLProduct : IRepository<Product,int>
    {
        DALProduct dalProduct = new DALProduct();

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
           return dalProduct.GetAll();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
