using NewCRM.Databases.Entities;
using NewCRM.Services;
using System;

namespace NewCRM.Controllers
{
    public class CustomerController : ICustomerController
    {
        private readonly ICustomerService _customerService;
        public CustomerController(
            ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public void OnCreate()
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
            catch(Exception e)
            {
                //Console.WriteLine("Something no ok detail Customer: " + e);
                //throw new NotImplementedException();
            }
        }

        public void OnDelete(int id)
        {
            try
            {
                //Call to service
                _customerService.DeleteCustomer(id);
                //Render to view
                Console.WriteLine("Successfully delete customer have id: " + id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw new NotImplementedException();
            }
        }

        public void OnDetails(int id)
        {
            try
            {
                //Call to service
                var customer = _customerService.GetDetailCustomer(id);
                //Render to view
                View.DetailCustomer.Instance.Show(customer);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Error when get detail Customer");
            }
        }

        public void OnGet()
        {
            try
            {
                //Call to service
                var customers = _customerService.GetAllCustomer();
                //Render to view
                View.AllCustomer.Instance.Show(customers);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Error when get Customer");
                //throw new NotImplementedException();
            }
        }

        public void OnPost()
        {
            throw new NotImplementedException();
        }

        public void OnUpdate(int id)
        {
            try
            {
                //Request infomation from view
                var customer = View.CreateUpdateCustomer.Instance.Request();
                customer.customerID = id;
                //Call to service
                _customerService.UpdateCustomer(customer);
                //Render to view
                View.CreateUpdateCustomer.Instance.Show(customer);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                //throw new NotImplementedException();
            }
        }
    }
}
