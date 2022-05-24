using NewCRM.Databases.Entities;
using NewCRM.Databases.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCRM.View
{
    public class CreateUpdateContactAddress : IUserInterface<ContactAddress>
    {
        private static CreateUpdateContactAddress _Instance;
        public static CreateUpdateContactAddress Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CreateUpdateContactAddress();
                }
                return _Instance;
            }
            private set { }
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

        public void Show(ContactAddress entity)
        {
            Console.WriteLine("Successfully");
        }

        public (ContactAddress, int) Request()
        {
            var contactAddress = new ContactAddress();
            Console.WriteLine("Information of Contact Address");
            contactAddress.addressType = (AddressType)Convert.ToInt32(InputSelection("Address type: "));
            contactAddress.address = InputSelection("Address: ");
            contactAddress.email = InputSelection("Email: ");
            contactAddress.phone = InputSelection("Phone: ");
            int id = Convert.ToInt32(InputSelection("CustomerID: "));
            return (contactAddress, id);
        }
    }
}
