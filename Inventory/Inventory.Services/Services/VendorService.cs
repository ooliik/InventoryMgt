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
    public class VendorService : BaseService, IVendorService
    {
        public VendorService(IUnitOfWork uow) : base(uow)
        {
        }

        public void AddOrUpdateVendor(VendorVm vendorVm)
        {
            var vendor = Mapper.Map<Vendor>(vendorVm);
            _uow.Repository<Vendor>().AddOrUpdate(x => x.VendorID == vendor.VendorID, vendor);
            _uow.Save();
        }

        public VendorVm GetVendor(Expression<Func<Vendor, bool>> filterPredicate = null)
        {
            Vendor vendor = _uow.Repository<Vendor>().Get(filterPredicate, false, null);
            VendorVm vendorVm = Mapper.Map<VendorVm>(vendor);
            return vendorVm;
        }

        public IEnumerable<VendorVm> GetVendors(Expression<Func<Vendor, bool>> filterPredicate = null)
        {
            IEnumerable<Vendor> vendors = _uow.Repository<Vendor>().GetRange(filterPredicate,
                false,
                x => x.OrderByDescending(p => p.VendorID), null, null, null);
            IEnumerable<VendorVm> vendorVm = Mapper.Map<IEnumerable<VendorVm>>(vendors);
            return vendorVm;
        }
    }
}
