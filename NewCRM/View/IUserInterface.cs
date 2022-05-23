using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCRM.View
{
    public interface IUserInterface<T>
    {
        //Show main menu
        public void Show(T entity);
        //Process input selection
        public string InputSelection(string output);
        //Process selection
        public bool ProcessSelection(string input);
    }
}
