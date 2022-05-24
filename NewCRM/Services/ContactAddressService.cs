using NewCRM.Databases.Entities;
using NewCRM.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void CreateContactAddress(ContactAddress contactAddress, int idCustomer)
        {
            var customer = _customerRepository.GetDetails(idCustomer);
            customer.Contact.Add(contactAddress);
            contactAddress.customer = customer;
            _customerRepository.Update(customer);
        }

        public void DeleteContactAddress(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateContactAddress(ContactAddress customer, int idCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
