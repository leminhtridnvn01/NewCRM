using NewCRM.Databases.Entities;
using System;

namespace NewCRM.View
{
    public class DetailCustomer : IUserInterface<Customer>
    {
        private static DetailCustomer _Instance;
        public static DetailCustomer Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DetailCustomer();
                }
                return _Instance;
            }
            private set { }
        }
        public void Show(Customer customer)
        {
            Console.WriteLine("ID: " + customer.customerID);
            Console.WriteLine("Name: " + customer.name);
            Console.WriteLine("Age: " + customer.yearOfBirth);
            foreach (ContactAddress contact in customer.Contact)
            {
                Console.WriteLine(contact.addressType.ToString() + " Address");
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("Email: " + contact.email);
                Console.WriteLine("Phone: " + contact.phone);
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
