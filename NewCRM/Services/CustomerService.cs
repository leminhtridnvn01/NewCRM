using NewCRM.Databases.Entities;
using NewCRM.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace NewCRM.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository<Customer> _customerRepository;
        private readonly IContactAddressRepository<ContactAddress> _contactAddressRepository;
        public CustomerService(
            ICustomerRepository<Customer> customerRepository,
            IContactAddressRepository<ContactAddress> contactAddressRepository
            )
        {
            _customerRepository = customerRepository;
            _contactAddressRepository = contactAddressRepository;
        }

        #region GetAllCustomer
        public List<Customer> GetAllCustomer()
        {
            return _customerRepository.GetList();
        }
        #endregion

        #region GetDetailCustomer
        public Customer GetDetailCustomer(int id)
        {
            // Get customer detail
            var customer = _customerRepository.GetDetails(id);
            
            // Get address of customer
            var contactAddresses = _contactAddressRepository.GetListByIDCustomer(id);

            // Add address into customer
            customer.Contact.AddRange(contactAddresses);

            return customer;
        }
        #endregion

        #region CreateCustomer
        public void CreateCustomer(Customer customer)
        {
            // Create customer
            _customerRepository.Create(customer);

            // Create address of customer
            foreach(ContactAddress contact in customer.Contact)
            {
                _contactAddressRepository.Create(contact);
            }
        }
        #endregion

        #region UpdateCustomer
        public void UpdateCustomer(Customer customer)
        {
            // Get ID contact by ID customer
            var idContacts = _contactAddressRepository.GetListIDContactByIDCustomer(customer.customerID);

            // Update contact of customer
            foreach (var (contact, index) in customer.Contact.Select((value, i) => (value, i)))
            {
                contact.contactID = idContacts[index];
                contact.customer = null;
                _contactAddressRepository.Update(contact);
            }

            // Update customer
            _customerRepository.Update(customer);
        }
        #endregion

        #region DeleteCustomer
        public void DeleteCustomer(int id)
        {
            // Get ID contact of customer
            var idContacts = _contactAddressRepository.GetListIDContactByIDCustomer(id);

            // Delete contact of customer
            foreach (var (idContact, index) in idContacts.Select((value, i) => (value, i)))
            {
                _contactAddressRepository.Delete(idContacts[index]);
            }

            // Delete customer
            _customerRepository.Delete(id);
        }
        #endregion
    }
}
