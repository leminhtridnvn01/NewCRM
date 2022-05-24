using NewCRM.Databases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCRM.Services
{
    public interface IContactAddressService
    {
        //1. Service create contact
        public void CreateContactAddress(ContactAddress contact, int idCustomer);
        //2. Service update contact
        public void UpdateContactAddress(ContactAddress contact, int idCustomer);
        //3. Service delete contact
        public void DeleteContactAddress(int id);
    }
}
