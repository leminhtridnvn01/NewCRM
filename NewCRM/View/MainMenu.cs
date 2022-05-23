using System;

namespace NewCRM.View
{
    public class MainMenu
    {
        private static MainMenu _Instance;
        public static MainMenu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new MainMenu();
                }
                return _Instance;
            }
            private set { }
        }

        //Show main menu
        public void Show()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. View list Customer");
            Console.WriteLine("2. View detail a Customer");
            Console.WriteLine("3. Add a new Customer");
            Console.WriteLine("4. Edit an existing Customer");
            Console.WriteLine("5. Delete an existing  Customer");
            Console.WriteLine("6. Create a Contact Address for an existing  Customer");
            Console.WriteLine("7. Update Contact Address for an existing  Customer");
            Console.WriteLine("8. Delete Contact Address for an existing  Customer");
        }

        //Process input selection
        public string InputSelection()
        {
            Console.Write("Your selection: ");
            return Console.ReadLine();
        }

        //Process selection
        public bool ProcessSelection(string input)
        {
            switch (input)
            {
                //Define method view list customer
                case "1":
                    //if (ViewListCustomer.Instance.View()) return true;
                    break;
                //Define method view detail an existing customer
                case "2":
                    //if (DetailCustomer.Instance.View()) return true;
                    break;
                //Define method add a new customer
                case "3":
                    //if (CreateCustomer.Instance.View()) return true;
                    break;
                //Define method edit an existing customer
                case "4":
                    //if (UpdateCustomer.Instance.View()) return true;
                    break;
                //Define method delete an existing customer
                case "5":
                    //if (DeleteCustomer.Instance.View()) return true;
                    break;
                //Define method add a new contact address for an existing customer
                case "6":
                    //if (CreateContactAddress.Instance.View()) return true;
                    break;
                //Define method edit contact address for an existing customer
                case "7":
                    //if (UpdateContactAddress.Instance.View()) return true;
                    break;
                //Define method delete contact address for an existing customer
                case "8":
                    //if (DeleteContactAddress.Instance.View()) return true;
                    break;
                //Choice the option does not contain in menu
                default:
                    Console.WriteLine("Error");
                    Console.WriteLine("Do you want to continues: ");
                    string confirm = Console.ReadLine();
                    if (confirm == "1") return true;
                    break;
            }
            return false;
        }
    }
}
