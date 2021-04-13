using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionCore.Models
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}
