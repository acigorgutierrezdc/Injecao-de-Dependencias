using dotnetcore_dependency_injection.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore_dependency_injection.Services
{
    public class CustomerServiceB 
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ILogger<CustomerServiceB> _logger;
        public CustomerServiceB(ICustomerRepository customerRepository, ILogger<CustomerServiceB> logger)
        {
            _logger = logger;
            _customerRepository = customerRepository;
        }

        public void AddCustomer(string name)
        {
            _customerRepository.Insert(name);
        }
    }
}
