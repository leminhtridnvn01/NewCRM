using NewCRM.Databases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewCRM.Databases.Entities;

namespace NewCRM.Repositories
{
    public interface IContactAddressRepository<ContactAddress> : IRepository<ContactAddress> where ContactAddress : class
    {
        public List<NewCRM.Databases.Entities.ContactAddress> GetListByIDCustomer(int id);
        public List<int> GetListIDContactByIDCustomer(int id);
    }
}
