using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Inventory.BLL.Entities;
using Inventory.ViewModels;

namespace Inventory.Services.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<CustomerVm> GetCustomers(Expression<Func<Customer, bool>> filterPredicate = null);
        CustomerVm GetCustomer(Expression<Func<Customer, bool>> filterPredicate = null);
        void AddOrUpdateCustomer(CustomerVm customerVm);
    }
}
