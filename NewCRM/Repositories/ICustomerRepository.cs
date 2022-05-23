using NewCRM.Databases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCRM.Repositories
{
    public interface ICustomerRepository<Customer> : IRepository<Customer> where Customer : class
    {
    }
}
