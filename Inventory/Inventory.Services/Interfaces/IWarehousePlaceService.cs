using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Inventory.BLL.Entities;
using Inventory.ViewModels;

namespace Inventory.Services.Interfaces
{
    public interface IWarehousePlaceService
    {
        IEnumerable<WarehousePlaceVm> GetWarehousePlaces(Expression<Func<WarehousePlace, bool>> filterPredicate = null);
        WarehousePlaceVm GetWarehousePlace(Expression<Func<WarehousePlace, bool>> filterPredicate = null);
        void AddOrUpdateWarehousePlace(WarehousePlaceVm warehousePlaceVm);
    }
}
