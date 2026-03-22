using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;

namespace BLL
{
    public class BLLCustomer : IRepository<Customer, int>
    {
        readonly IRepository<Customer> dalCustomer;

        public BLLCustomer()
        {
            dalCustomer = new DALCustomer();
        }
        public void Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer item)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            return dalCustomer.GetAll();
        }

        public Customer GetById(int id)
        {
           return dalCustomer.GetAll().Find(C => C.IDNumber == id);
        }

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}