using NewCRM.Databases.Entities;
using NewCRM.Databases.Enums;
using System;

namespace NewCRM.View
{
    public class CreateUpdateCustomer : IUserInterface<Customer>
    {
        private static CreateUpdateCustomer _Instance;
        public static CreateUpdateCustomer Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CreateUpdateCustomer();
                }
                return _Instance;
            }
            private set { }
        }
        public Customer Request()
        {
            var customer = new Customer();
            Console.WriteLine("Information of Customer");
            customer.name = InputSelection("Name: ");
            customer.yearOfBirth = InputSelection("Year Of Birth: ");
            foreach(string contact in Enum.GetNames(typeof(AddressType)))
            {
                var contactAddress = new ContactAddress();
                Console.WriteLine(contact + " Address");
                contactAddress.address = InputSelection("Address: ");
                contactAddress.email = InputSelection("Email: ");
                contactAddress.phone = InputSelection("Phone: ");
                contactAddress.customer = customer;
                if (contactAddress.address == "" && contactAddress.email == "" && contactAddress.phone == "") continue;
                customer.Contact.Add(contactAddress);
            }
            return customer;
        }
        public void Show(Customer customer)
        {
            Console.WriteLine("Successfully");
        }
        public string InputSelection(string output)
        {
            Console.Write(output + ": ");
            return Console.ReadLine();
        }

        public bool ProcessSelection(string input)
        {
            throw new NotImplementedException();
        }

        
    }
}
