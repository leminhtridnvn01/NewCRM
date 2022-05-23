using Microsoft.Extensions.DependencyInjection;
using NewCRM.Controllers;
using NewCRM.Databases.Entities;
using NewCRM.Repositories;
using NewCRM.Services;
using NewCRM.View;
using System;
using System.Collections.Generic;

namespace NewCRM
{
    class Program
    {
        private readonly IUserInterface<object> _mainMenu;
        public Program(IUserInterface<object> mainMenu)
        {
            _mainMenu = mainMenu;
        }
        public static void Main(string[] args)
        {
            //DI register
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IUserInterface<object>, MainMenu >()
                .AddSingleton<IUserInterface<List<Customer>>, AllCustomer >()
                .AddSingleton<IUserInterface<Customer>, DetailCustomer >()
                .AddSingleton<IUserInterface<Customer>, CreateUpdateCustomer >()
                .AddSingleton<ICustomerController, CustomerController>()
                .AddSingleton<ICustomerRepository<Customer>, CustomerRepository<Customer>>()
                .AddSingleton<ICustomerService, CustomerService>()
                .AddSingleton<IContactAddressRepository<ContactAddress>, ContactAddressRepository<ContactAddress>>()
                .BuildServiceProvider();
            while (true)
            {
                //1. Show main menu
                var i = serviceProvider.GetService<CustomerService>();
                serviceProvider.GetService<IUserInterface<object>>().Show(null);
                //2. Input seletion
                var input = serviceProvider.GetService<IUserInterface<object>>().InputSelection("");
                //3. Processing selection
                if(!serviceProvider.GetService<IUserInterface<object>>().ProcessSelection(input)) break;
            }
            
        }

    }
}
