using Microsoft.Extensions.DependencyInjection;
using NewCRM.Controllers;
using NewCRM.Databases.Entities;
using NewCRM.Repositories;
using NewCRM.Services;
using NewCRM.View;
using System.Collections.Generic;

namespace NewCRM
{
    class Program
    {
        public static void Main(string[] args)
        {
            // DI register
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IUserInterface<object>, MainMenu >()
                .AddSingleton<IUserInterface<List<Customer>>, AllCustomer >()
                .AddSingleton<IUserInterface<Customer>, DetailCustomer >()
                .AddSingleton<IUserInterface<Customer>, CreateUpdateCustomer >()
                .AddSingleton<ICustomerController, CustomerController>()
                .AddSingleton<IContactAddressController, ContactAddressController>()
                .AddSingleton<ICustomerRepository<Customer>, CustomerRepository<Customer>>()
                .AddSingleton<ICustomerService, CustomerService>()
                .AddSingleton<IContactAddressService, ContactAddressService>()
                .AddSingleton<IContactAddressRepository<ContactAddress>, ContactAddressRepository<ContactAddress>>()
                .BuildServiceProvider();

            // Menu
            while (true)
            {
                // 1. Show main menu
                serviceProvider.GetService<IUserInterface<object>>().Show(null);

                // 2. Input seletion
                var input = serviceProvider.GetService<IUserInterface<object>>().InputSelection("Your selection: ");

                // 3. Processing selection
                if(serviceProvider.GetService<IUserInterface<object>>().ProcessSelection(input) == 0) break;
            }         
        }
    }
}
