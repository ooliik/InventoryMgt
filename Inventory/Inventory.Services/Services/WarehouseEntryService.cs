using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Inventory.BLL.Entities;
using Inventory.Services.Interfaces;
using Inventory.ViewModels;
using System.Linq;
using DataAccessLayer.Core.Interfaces.UoW;
using AutoMapper;


namespace Inventory.Services.Services
{
    public class WarehouseEntryService : BaseService, IWarehouseEntryService
    {
        public WarehouseEntryService(IUnitOfWork uow) : base(uow)
        {
        }

        public void AddWarehouseEntry(WarehouseEntryVm warehouseEntryVm)
        {
            var warehouseEntry = Mapper.Map<WarehouseEntry>(warehouseEntryVm);
            _uow.Repository<WarehouseEntry>().Add(warehouseEntry);
            _uow.Save();
        }

        public IEnumerable<WarehouseEntryVm> GetWarehouseEntries(Expression<Func<WarehouseEntry, bool>> filterPredicate = null)
        {
            IEnumerable<WarehouseEntry> warehouseEntries = _uow.Repository<WarehouseEntry>().GetRange(filterPredicate,
                false,
                x => x.OrderByDescending(p => p.EntryNumber), null, null, null);
            IEnumerable<WarehouseEntryVm> warehouseEntryVm = Mapper.Map<IEnumerable<WarehouseEntryVm>>(warehouseEntries);
            return warehouseEntryVm;
        }

        public WarehouseEntryVm GetWarehouseEntry(Expression<Func<WarehouseEntry, bool>> filterPredicate = null)
        {
            WarehouseEntry warehouseEntry = _uow.Repository<WarehouseEntry>().Get(filterPredicate, false, null);
            WarehouseEntryVm warehouseEntryVm = Mapper.Map<WarehouseEntryVm>(warehouseEntry);
            return warehouseEntryVm;
        }
    }
}
