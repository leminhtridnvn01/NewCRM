using NewCRM.View;
using System;

namespace NewCRM
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Show main menu
            MainMenu.Instance.Show();
            //2. Input seletion
            var input = MainMenu.Instance.InputSelection();
            //3. Processing selection
            MainMenu.Instance.ProcessSelection(input);
        }
    }
}
