using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Inventory.BLL.Entities;
using Inventory.ViewModels;
using System.Text;

namespace Inventory.Services.Interfaces
{
    public interface IWarehouseService
    {
        IEnumerable<WarehouseVm> GetWarehouses(Expression<Func<Warehouse, bool>> filterPredicate = null);
        WarehouseVm GetWarehouse(Expression<Func<Warehouse, bool>> filterPredicate = null);
        void AddOrUpdateWarehouse(WarehouseVm warehouseVm);
    }
}
