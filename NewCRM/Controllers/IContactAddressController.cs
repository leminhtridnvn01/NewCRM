using NewCRM.Databases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCRM.Controllers
{
    public interface IContactAddressController : Controller<ContactAddress>
    {
        public void OnCreate(int idCustomer);
    }
}
