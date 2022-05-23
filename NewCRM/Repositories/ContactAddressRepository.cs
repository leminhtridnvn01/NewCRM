﻿using NewCRM.Databases;
using NewCRM.Databases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCRM.Repositories
{
    public class ContactAddressRepository<ContactAddress> : IContactAddressRepository<ContactAddress> where ContactAddress : class
    {
        public List<NewCRM.Databases.Entities.ContactAddress> GetListByIDCustomer(int id)
        {
            Context db = new Context();
            var l = db.ContactAddresses.Where(p => p.customer.customerID == id).Select(p => p).ToList();
            return l;
        }

        public List<int> GetListIDContactByIDCustomer(int id)
        {
            Context db = new Context();
            var idContactAddresses = db.ContactAddresses.Where(p => p.customer.customerID == id).Select(p => p.contactID).ToList();
            return idContactAddresses;
        }
    }
}
