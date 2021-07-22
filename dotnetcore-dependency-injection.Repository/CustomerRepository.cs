using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnetcore_dependency_injection.Repository
{
    public class CustomerRepository  : ICustomerRepository
    {

        private readonly IList<string> _customers;
        private readonly ILogger<CustomerRepository> _logger;
        private readonly Guid _instanceId = Guid.NewGuid();

        public CustomerRepository(ILogger<CustomerRepository> logger)
        {
            _logger = logger;
            _customers = new List<String>();

            _logger.LogInformation($"Repo Instanceid{_instanceId}. Info: Repositório criado com sucesso");
        }

        public void Insert(string name) {
            _customers.Add(name);

            _logger.LogInformation($"Repo Instanceid{_instanceId}. Info: cliente criado com sucesso");
        }
    }
}
