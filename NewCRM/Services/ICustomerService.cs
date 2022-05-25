using NewCRM.Databases.Entities;
using System.Collections.Generic;

namespace NewCRM.Services
{
    public interface ICustomerService
    {
        //1. Service get all customer
        List<Customer> GetAllCustomer();

        //2. Service get detail customer
        public Customer GetDetailCustomer(int id);

        //3. Service create customer
        public void CreateCustomer(Customer customer);

        //4. Service update customer
        public void UpdateCustomer(Customer customer);

        //5. Service delete customer
        public void DeleteCustomer(int id);
    }
}
