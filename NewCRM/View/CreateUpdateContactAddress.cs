using NewCRM.Databases.Entities;
using NewCRM.Databases.Enums;
using System;

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

        #region Show
        public void Show(ContactAddress entity)
        {
            Console.WriteLine("Successfully");
        }
        #endregion

        #region InputSelection
        public string InputSelection(string output)
        {
            Console.Write(output + ": ");
            return Console.ReadLine();
        }

        public ContactAddress Request()
        {
            var contactAddress = new ContactAddress();
            Console.WriteLine("Information of Contact Address");
            contactAddress.addressType = (AddressType)Convert.ToInt32(InputSelection("Address type: "));
            contactAddress.address = InputSelection("Address: ");
            contactAddress.email = InputSelection("Email: ");
            contactAddress.phone = InputSelection("Phone: ");
            return contactAddress;
        }
        #endregion

        #region ProcessSelection
        public int ProcessSelection(string input)
        {
            var intInput = View.Validate.Instance.ValidateID(input);
            return intInput;
        }
        #endregion
    }
}
