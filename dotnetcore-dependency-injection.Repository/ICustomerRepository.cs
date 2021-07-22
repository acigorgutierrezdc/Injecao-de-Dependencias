using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore_dependency_injection.Repository
{
    public interface ICustomerRepository
    {
        void Insert(string name);
    }
}
