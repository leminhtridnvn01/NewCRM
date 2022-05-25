using NewCRM.Databases.Entities;
using NewCRM.Repositories;
using NewCRM.Services;
using System;

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
            IContactAddressRepository<ContactAddress> contacAddressRepository
            )
        {
            _customerService = customerService;
            _contactAddressService = contactAddressService;
            _contacAddressRepository = contacAddressRepository;
        }

        #region Create
        public void OnCreate()
        {
            try
            {
                // Request infomation from view
                var idView = View.CreateUpdateCustomer.Instance.InputSelection("Enter ID Custormer");
                if (View.Validate.Instance.ValidateID(idView) == -1) return;
                var id = View.Validate.Instance.ValidateID(idView);
                var contactAddress = View.CreateUpdateContactAddress.Instance.Request();

                // Call to service
                _contactAddressService.CreateContactAddress(contactAddress, id);

                // Render to view
                View.CreateUpdateContactAddress.Instance.Show(contactAddress);
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        #region Delete
        public void OnDelete()
        {
            try
            {
                // Request id customer form view
                var idView = View.CreateUpdateCustomer.Instance.InputSelection("Enter ID Custormer");
                var id = View.Validate.Instance.ValidateID(idView);
                if (id == -1) return;

                // Get customer detail
                var customer = _customerService.GetDetailCustomer(id);

                // Render contact infomation from view
                View.DetailCustomer.Instance.Show(customer);

                // Request infomation from view
                Console.Write("Choose index: ");
                var index = Convert.ToInt32(Console.ReadLine());
                //Call to service
                _contactAddressService.DeleteContactAddress(id, index);

                // Render to view
                Console.WriteLine("Successfully delete contact");
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        #region Detail
        public void OnDetails()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Get
        public void OnGet()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Update
        public void OnUpdate()
        {
            try
            {
                // Request id customer form view
                var idView = View.CreateUpdateCustomer.Instance.InputSelection("Enter ID Custormer");
                var id = View.Validate.Instance.ValidateID(idView);
                if (id == -1) return;

                // Get customer detail
                var customer = _customerService.GetDetailCustomer(id);

                // Render contact infomation from view
                View.DetailCustomer.Instance.Show(customer);

                // Request infomation from view
                Console.Write("Choose index: ");
                var index = Convert.ToInt32(Console.ReadLine());
                var newContact = View.CreateUpdateContactAddress.Instance.Request();

                // Call to service
                _contactAddressService.UpdateContactAddress(id, customer.Contact[index - 1], newContact);

                // Render to view
                View.CreateUpdateCustomer.Instance.Show(customer);
            }
            catch (Exception e)
            {
            }
        }
        #endregion
    }
}
