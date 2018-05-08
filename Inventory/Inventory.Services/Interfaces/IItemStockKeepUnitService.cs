using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Inventory.BLL.Entities;
using Inventory.ViewModels;
using System.Text;

namespace Inventory.Services.Interfaces
{
    public interface IItemStockKeepUnitService
    {
        IEnumerable<ItemStockKeepUnitVm> GetItemStockKeepUnits(Expression<Func<ItemStockKeepUnit, bool>> filterPredicate = null);
        ItemStockKeepUnitVm GetItemStockKeepUnit(Expression<Func<ItemStockKeepUnit, bool>> filterPredicate = null);
        void AddItemStockKeepUnit(ItemStockKeepUnitVm itemStockKeepUnitVm);
    }
}
