using NewCRM.Databases.Enums;
using System.ComponentModel.DataAnnotations;

namespace NewCRM.Databases.Entities
{
    public class ContactAddress
    {
        [Key]
        public int contactID { get; set; }
        public AddressType addressType { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public Customer customer { get; set; }
    }
}
