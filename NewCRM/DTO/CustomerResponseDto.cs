using NewCRM.Databases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
