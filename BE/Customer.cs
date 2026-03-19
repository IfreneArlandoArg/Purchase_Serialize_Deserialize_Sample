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


        public Customer(int idNumber, string firstName, string lastName, MaritalStatus maritalStatus, DateTime birthDate,  string fullAdress)
        {
            IDNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            MaritalStatus = maritalStatus;
            BirthDate = birthDate;
            FullAddress = fullAdress;

        }

        public int GetAge() 
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }





    }
}