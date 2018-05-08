using System;
using System.Collections.Generic;
using System.Text;
using Inventory.BLL.Entities;
using Inventory.Services.Interfaces;
using Inventory.ViewModels;
using System.Linq.Expressions;
using System.Linq;
using DataAccessLayer.Core.Interfaces.UoW;
using AutoMapper;

namespace Inventory.Services.Services
{
    public class CustomerService : BaseService, ICustomerService
    {
        public CustomerService(IUnitOfWork uow) : base(uow)
        {
        }
        public void AddOrUpdateCustomer(CustomerVm customerVm)
        {
            var customer = Mapper.Map<Customer>(customerVm);
            _uow.Repository<Customer>().AddOrUpdate(x => x.CustomerID == customer.CustomerID, customer);
            _uow.Save();
        }

        public CustomerVm GetCustomer(Expression<Func<Customer, bool>> filterPredicate = null)
        {
            Customer customer = _uow.Repository<Customer>().Get(filterPredicate, false, null);
            CustomerVm customerVm = Mapper.Map<CustomerVm>(customer);
            return customerVm;
        }

        public IEnumerable<CustomerVm> GetCustomers(Expression<Func<Customer, bool>> filterPredicate = null)
        {
            IEnumerable<Customer> customers = _uow.Repository<Customer>().GetRange(filterPredicate,
                false,
                x => x.OrderByDescending(p => p.CustomerID), null, null, null);
            IEnumerable<CustomerVm> customerVm = Mapper.Map<IEnumerable<CustomerVm>>(customers);
            return customerVm;
        }
    }
}
