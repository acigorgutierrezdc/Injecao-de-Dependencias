using dotnetcore_dependency_injection.Repository;
using Microsoft.Extensions.Logging;
using System;

namespace dotnetcore_dependency_injection.Services
{
    public class CustomerServiceA
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ILogger<CustomerServiceA> _logger;
        public CustomerServiceA(ICustomerRepository customerRepository, ILogger<CustomerServiceA> logger)
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
