using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCRM.Controllers
{
    public interface Controller<T>
    {
        public void OnGet();
        public void OnPost();
        public void OnDetails(int id);
        public void OnCreate();
        public void OnUpdate(int id);
        public void OnDelete(int id);
    }
}
