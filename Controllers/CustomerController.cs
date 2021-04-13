using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionCore.Services;

namespace DependencyInjectionCore.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _iCustomerService;

        public CustomerController(ICustomerService iCustomerService)
        {
            _iCustomerService = iCustomerService;
        }

        // GET: Customer
        public JsonResult GetCustomers()
        {
            return Json(_iCustomerService.GetCustomers());
        }
    }
}
