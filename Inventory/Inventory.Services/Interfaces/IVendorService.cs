using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Inventory.BLL.Entities;
using Inventory.ViewModels;

namespace Inventory.Services.Interfaces
{
    public interface IVendorService
    {
        IEnumerable<VendorVm> GetVendors(Expression<Func<Vendor, bool>> filterPredicate = null);
        VendorVm GetVendor(Expression<Func<Vendor, bool>> filterPredicate = null);
        void AddOrUpdateVendor(VendorVm vendorVm);
    }
}
