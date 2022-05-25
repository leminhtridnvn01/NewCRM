using System.Collections.Generic;

namespace NewCRM.Repositories
{
    public interface IContactAddressRepository<ContactAddress> : IRepository<ContactAddress> where ContactAddress : class
    {
        public List<NewCRM.Databases.Entities.ContactAddress> GetListByIDCustomer(int id);
        public List<int> GetListIDContactByIDCustomer(int id);
    }
}
