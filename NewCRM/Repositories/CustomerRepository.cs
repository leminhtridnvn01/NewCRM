using NewCRM.Databases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCRM.Repositories
{
    public class CustomerRepository<Customer> : ICustomerRepository<Customer> where Customer : class
    {

    }
}
