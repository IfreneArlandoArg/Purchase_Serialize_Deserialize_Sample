using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALCustomer : IRepository<Customer>
    {
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
            return new List<Customer>
            {
                new Customer
                {
                    IDNumber = 87654321,
                    FirstName = "Jane",
                    LastName = "Smith",
                    MaritalStatus = MaritalStatus.Married,
                    BirthDate = new DateTime(1985, 10, 20, 0, 0, 0, DateTimeKind.Utc),
                    FullAddress = "456 Elm St, Othertown, USA"
                },
                new Customer
                {
                    IDNumber = 12345678,
                    FirstName = "John",
                    LastName = "Doe",
                    MaritalStatus = MaritalStatus.Single,
                    BirthDate = new DateTime(1999, 5, 15, 0, 0, 0, DateTimeKind.Utc),
                    FullAddress = "123 Main St, Anytown, USA"
                }
            };
        }

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}