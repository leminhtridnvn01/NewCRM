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

        #region Show
        public void Show(Customer customer)
        {
            // Show customer info
            Console.WriteLine("ID: " + customer.customerID);
            Console.WriteLine("Name: " + customer.name);
            Console.WriteLine("Age: " + customer.yearOfBirth);

            // Show contact info
            foreach (ContactAddress contact in customer.Contact)
            {
                Console.WriteLine(contact.addressType.ToString() + " Address");
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("Email: " + contact.email);
                Console.WriteLine("Phone: " + contact.phone);
                Console.WriteLine("");
            }
        }
        #endregion

        #region InputSelection
        public string InputSelection(string output)
        {
            Console.Write(output + ": ");
            return Console.ReadLine();
        }
        #endregion

        #region ProcessSelection
        public int ProcessSelection(string input)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
