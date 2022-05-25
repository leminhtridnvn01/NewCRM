using NewCRM.Controllers;
using System;

namespace NewCRM.View
{
    public class MainMenu : IUserInterface<object>
    {
        private readonly ICustomerController _customerController;
        private readonly IContactAddressController _contactAddressController;
        public MainMenu(
            ICustomerController customerController,
            IContactAddressController contactAddressController
            )
        {
            _customerController = customerController;
            _contactAddressController = contactAddressController;
        }

        #region Show
        public void Show(object entity)
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
        #endregion

        #region InputSelection
        public string InputSelection(string output)
        {
            Console.Write(output + ": ");
            return Console.ReadLine();
        }
        #endregion

        #region ProcessSelection
        public int ProcessSelection(string input)
        {
            switch (input)
            {
                // Define method view list customer
                case "1":
                    _customerController.OnGet();
                    if (ConfirmContinue()) return 1;
                    break;

                // Define method view detail an existing customer
                case "2":
                    _customerController.OnDetails();
                    if (ConfirmContinue()) return 1;
                    break;

                // Define method add a new customer
                case "3":
                    _customerController.OnCreate();
                    if (ConfirmContinue()) return 1;
                    break;

                // Define method edit an existing customer
                case "4":
                    _customerController.OnUpdate();
                    if (ConfirmContinue()) return 1;
                    break;

                // Define method delete an existing customer
                case "5":
                    _customerController.OnDelete();
                    if (ConfirmContinue()) return 1;
                    break;

                // Define method add a new contact address for an existing customer
                case "6":
                    _contactAddressController.OnCreate();
                    if (ConfirmContinue()) return 1;
                    break;

                // Define method edit contact address for an existing customer
                case "7":
                    _contactAddressController.OnUpdate();
                    if (ConfirmContinue()) return 1;
                    break;

                // Define method delete contact address for an existing customer
                case "8":
                    _contactAddressController.OnDelete();
                    if (ConfirmContinue()) return 1;
                    break;

                // Choice the option does not contain in menu
                default:
                    Console.WriteLine("Error");
                    string confirm = InputSelection("Do you want to continues: ");
                    if (confirm == "1") return 1;
                    break;
            }
            return 0;
        }
        public bool ConfirmContinue()
        {
            string confirm = InputSelection("Do you want to continues? (1.Yes, 2.No)");
            if (confirm == "1") return true;
            return false;
        }
        #endregion
    }
}
