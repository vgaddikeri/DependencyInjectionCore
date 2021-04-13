using DependencyInjectionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionCore.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
    }
}
