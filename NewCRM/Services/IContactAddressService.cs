using NewCRM.Databases.Entities;

namespace NewCRM.Services
{
    public interface IContactAddressService
    {
        //1. Service create contact
        public void CreateContactAddress(ContactAddress contact, int idCustomer);

        //2. Service update contact
        public void UpdateContactAddress(int idCustomer, ContactAddress contact, ContactAddress newContact);

        //3. Service delete contact
        public void DeleteContactAddress(int idCustomer, int index);
    }
}
