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
        List<Customer> GetAllCustomer();
        public Customer GetDetailCustomer(int id);
        public void CreateCustomer(Customer customer);
        public void UpdateCustomer(int id, Customer customer);
    }
}
