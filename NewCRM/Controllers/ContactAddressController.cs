using NewCRM.Databases.Entities;
using NewCRM.Repositories;
using NewCRM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCRM.Controllers
{
    public class ContactAddressController : IContactAddressController
    {
        private readonly ICustomerService _customerService;
        private readonly IContactAddressService _contactAddressService;
        private readonly IContactAddressRepository<ContactAddress> _contacAddressRepository;
        public ContactAddressController(
            ICustomerService customerService,
            IContactAddressService contactAddressService,
            IContactAddressRepository<ContactAddress> contacAddressRepository)
        {
            _customerService = customerService;
            _contactAddressService = contactAddressService;
            _contacAddressRepository = contacAddressRepository;
        }
        public void OnCreate()
        {
            try
            {
                //Request infomation from view
                var (contactAddress, idCustomer) = View.CreateUpdateContactAddress.Instance.Request();
                //Call to service
                _contactAddressService.CreateContactAddress(contactAddress, idCustomer);
                //Render to view
                View.CreateUpdateContactAddress.Instance.Show(contactAddress);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Something no ok detail Customer: " + e);
                //throw new NotImplementedException();
            }
        }

        public void OnCreate(int idCustomer)
        {
            try
            {
                //Request infomation from view
                var customer = View.CreateUpdateCustomer.Instance.Request();
                //Call to service
                _customerService.CreateCustomer(customer);
                //Render to view
                View.CreateUpdateCustomer.Instance.Show(customer);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Something no ok detail Customer: " + e);
                //throw new NotImplementedException();
            }
        }

        public void OnDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void OnDetails(int id)
        {
            throw new NotImplementedException();
        }

        public void OnGet()
        {
            throw new NotImplementedException();
        }

        public void OnPost()
        {
            throw new NotImplementedException();
        }

        public void OnUpdate(int id)
        {
            try
            {
                //get customer detail
                var customer = _customerService.GetDetailCustomer(id);
                //Render contact infomation from view
                View.DetailCustomer.Instance.Show(customer);
                //Request infomation from view
                Console.Write("Choose index: ");
                var index = Convert.ToInt32(Console.ReadLine());
                var newContact = View.CreateUpdateContactAddress.Instance.Request();
                //get contact by index
                var contact = customer.Contact[index];
                contact.addressType = newContact.
                //Call to service
                _contactAddressService.UpdateContactAddress(customer, customer.customerID);
                //Render to view
                View.CreateUpdateCustomer.Instance.Show(customer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw new NotImplementedException();
            }
        }
    }
}
