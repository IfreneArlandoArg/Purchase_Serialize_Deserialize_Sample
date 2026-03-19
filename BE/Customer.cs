using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Customer
    {
        public int IDNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public MaritalStatus MaritalStatus { get; set; }
        public DateTime BirthDate { get; set; }

        public string FullAddress { get; set; }

        public Customer()
        {
                
        }
       

        public int GetAge() 
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }


        public string GetFullName() 
        { 
          return $"{FirstName} {LastName}";
        }


    }
}