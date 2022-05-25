using NewCRM.Services;
using System;

namespace NewCRM.Controllers
{
    public class CustomerController : ICustomerController
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        #region Create
        public void OnCreate()
        {
            try
            {
                // Request infomation from view
                var customer = View.CreateUpdateCustomer.Instance.Request();

                // Call to service
                _customerService.CreateCustomer(customer);

                // Render to view
                View.CreateUpdateCustomer.Instance.Show(customer);
            }
            catch(Exception e)
            {
            }
        }
        #endregion

        #region Delete
        public void OnDelete()
        {
            try
            {
                // Request id from view
                var idView = View.DetailCustomer.Instance.InputSelection("Enter ID Custormer");
                if (View.Validate.Instance.ValidateID(idView) == -1) return;
                var id = View.Validate.Instance.ValidateID(idView);

                // Call to service
                _customerService.DeleteCustomer(id);

                // Render to view
                Console.WriteLine("Successfully delete customer have id: " + id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        #endregion

        #region Detail
        public void OnDetails()
        {
            try
            {
                // Request id from view
                var idView = View.DetailCustomer.Instance.InputSelection("Enter ID Custormer");
                var id = View.Validate.Instance.ValidateID(idView);
                if ( id == -1) return;

                // Call to service
                var customer = _customerService.GetDetailCustomer(id);

                // Render to view
                View.DetailCustomer.Instance.Show(customer);
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        #region GetList
        public void OnGet()
        {
            try
            {
                // Call to service
                var customers = _customerService.GetAllCustomer();

                // Render to view
                View.AllCustomer.Instance.Show(customers);
            }
            catch (Exception e)
            {

            }
        }
        #endregion

        #region Update
        public void OnUpdate()
        {
            try
            {
                // Request infomation from view
                var idView = View.CreateUpdateCustomer.Instance.InputSelection("Enter ID Custormer");
                var id = View.Validate.Instance.ValidateID(idView);
                if ( id == -1) return;
                var customer = View.CreateUpdateCustomer.Instance.Request();
                customer.customerID = id;

                // Call to service
                _customerService.UpdateCustomer(customer);

                // Render to view
                View.CreateUpdateCustomer.Instance.Show(customer);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        #endregion
    }
}
