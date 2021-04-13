using DependencyInjectionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionCore.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _iCustomerRepository;

        //Dependency Injection we pass the interface variable through class constructor.The interface in turn will instantiate the right class
        //and call the function GetCustomers()

        public CustomerService(ICustomerRepository iCustomerRepository)
        {

            _iCustomerRepository = iCustomerRepository;
        }
        public List<Customer> GetCustomers()
        {
            return _iCustomerRepository.GetCustomers();
        }
    }
}
