using NewCRM.Databases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
