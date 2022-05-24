using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCRM.Controllers
{
    public interface Controller<T>
    {
        //1. Get list event
        public void OnGet();
        //2. Get detail event
        public void OnDetails(int id);
        //3. Create event
        public void OnCreate();
        //4. Update event
        public void OnUpdate(int id);
        //5. Delete event
        public void OnDelete(int id);
        public void OnPost();
    }
}
