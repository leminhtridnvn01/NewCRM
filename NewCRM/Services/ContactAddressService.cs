using NewCRM.Databases.Entities;
using NewCRM.Repositories;

namespace NewCRM.Services
{
    public class ContactAddressService : IContactAddressService
    {
        private readonly ICustomerRepository<Customer> _customerRepository;
        private readonly IContactAddressRepository<ContactAddress> _contactAddressRepository;
        public ContactAddressService(
            ICustomerRepository<Customer> customerRepository,
            IContactAddressRepository<ContactAddress> contactAddressRepository
            )
        {
            _customerRepository = customerRepository;
            _contactAddressRepository = contactAddressRepository;
        }

        #region CreateContactAddress
        public void CreateContactAddress(ContactAddress contactAddress, int idCustomer)
        {
            // Add new contact to existing customer
            var customer = _customerRepository.GetDetails(idCustomer);
            customer.Contact.Add(contactAddress);
            contactAddress.customer = customer;

            // Update customer
            _customerRepository.Update(customer);
        }
        #endregion

        #region DeleteContactAddress
        public void DeleteContactAddress(int idCustomer, int index)
        {
            var idContacts = _contactAddressRepository.GetListIDContactByIDCustomer(idCustomer);
            _contactAddressRepository.Delete(idContacts[index-1]);
        }
        #endregion

        #region UpdateContactAddress
        public void UpdateContactAddress(int idCustomer, ContactAddress contact, ContactAddress newContact)
        {
            // ID for new contact
            newContact.contactID = contact.contactID;

            // Update contact
            _contactAddressRepository.Update(newContact);
        }
        #endregion
    }
}
