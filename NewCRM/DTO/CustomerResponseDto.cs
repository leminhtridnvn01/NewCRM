using NewCRM.Databases.Entities;
using System.Collections.Generic;

namespace NewCRM.DTO
{
    public class CustomerResponseDto
    {
        public int customerID { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public List<ContactAddress> Contact { get; set; }
    }
}
