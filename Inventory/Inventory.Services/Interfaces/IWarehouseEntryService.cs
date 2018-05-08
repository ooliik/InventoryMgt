using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Inventory.BLL.Entities;
using Inventory.ViewModels;

namespace Inventory.Services.Interfaces
{
    public interface IWarehouseEntryService
    {
        IEnumerable<WarehouseEntryVm> GetWarehouseEntries(Expression<Func<WarehouseEntry, bool>> filterPredicate = null);
        WarehouseEntryVm GetWarehouseEntry(Expression<Func<WarehouseEntry, bool>> filterPredicate = null);
        void AddWarehouseEntry(WarehouseEntryVm warehouseEntryVm);
    }
}
