using NewCRM.Databases.Entities;
using System;
using System.Collections.Generic;

namespace NewCRM.View
{
    public class AllCustomer : IUserInterface<List<Customer>>
    {
        private static AllCustomer _Instance;
        public static AllCustomer Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new AllCustomer();
                }
                return _Instance;
            }
            private set { }
        }
        public void Show(List<Customer> customers)
        {
            //Show list customer
            foreach (Customer customer in customers)
            {
                Console.WriteLine("ID: " + customer.customerID);
                Console.WriteLine("Name: " + customer.name);
                Console.WriteLine("Age: " + customer.yearOfBirth);
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
        public string InputSelection(string output)
        {
            throw new NotImplementedException();
        }

        public bool ProcessSelection(string input)
        {
            throw new NotImplementedException();
        }
    }
}
