using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewCRM.Databases.Entities
{
    public class Customer
    {
        public Customer()
        {
            Contact = new List<ContactAddress>();
        }
        [Key]
        public int customerID { get; set; }
        public string name { get; set; }
        public string yearOfBirth { get; set; }
        public List<ContactAddress> Contact { get; set; }
    }
}
