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
    public class WarehouseService : BaseService, IWarehouseService
    {
        public WarehouseService(IUnitOfWork uow) : base(uow)
        {
        }

        public void AddOrUpdateWarehouse(WarehouseVm warehouseVm)
        {
            var warehouse = Mapper.Map<Warehouse>(warehouseVm);
            _uow.Repository<Warehouse>().AddOrUpdate(x => x.WarehouseName == warehouse.WarehouseName, warehouse);
            _uow.Save();
        }

        public WarehouseVm GetWarehouse(Expression<Func<Warehouse, bool>> filterPredicate = null)
        {
            Warehouse warehouse = _uow.Repository<Warehouse>().Get(filterPredicate, false, null);
            WarehouseVm warehouseVm = Mapper.Map<WarehouseVm>(warehouse);
            return warehouseVm;
        }

        public IEnumerable<WarehouseVm> GetWarehouses(Expression<Func<Warehouse, bool>> filterPredicate = null)
        {
            IEnumerable<Warehouse> warehouses = _uow.Repository<Warehouse>().GetRange(filterPredicate,
                false,
                x => x.OrderByDescending(p => p.WarehouseName), null, null, null);
            IEnumerable<WarehouseVm> warehouseVm = Mapper.Map<IEnumerable<WarehouseVm>>(warehouses);
            return warehouseVm;
        }
    }
}
