using NewCRM.Databases.Entities;
using NewCRM.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Customer> GetAllCustomer()
        {
            return _customerRepository.GetList();
        }
        public Customer GetDetailCustomer(int id)
        {
            var customer = _customerRepository.GetDetails(id);
            var contactAddresses = _contactAddressRepository.GetListByIDCustomer(id);
            customer.Contact.AddRange(contactAddresses);
            return customer;
        }
        public void CreateCustomer(Customer customer)
        {
            _customerRepository.Create(customer);
            foreach(ContactAddress contact in customer.Contact)
            {
                _contactAddressRepository.Create(contact);
            }
        }
        public void UpdateCustomer(Customer customer)
        {
            var idContacts = _contactAddressRepository.GetListIDContactByIDCustomer(customer.customerID);
            foreach (var (contact, index) in customer.Contact.Select((value, i) => (value, i)))
            {
                contact.contactID = idContacts[index];
                contact.customer = null;
                _contactAddressRepository.Update(contact);
            }
            _customerRepository.Update(customer);
        }
        public void DeleteCustomer(int id)
        {
            var customer = _customerRepository.GetDetails(id);
            var idContacts = _contactAddressRepository.GetListIDContactByIDCustomer(id);
            foreach (var (idContact, index) in idContacts.Select((value, i) => (value, i)))
            {
                _contactAddressRepository.Delete(idContacts[index]);
            }
            _customerRepository.Delete(id);
        }
    }
}
