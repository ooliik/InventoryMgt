using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Inventory.BLL.Entities;
using Inventory.ViewModels;

namespace Inventory.Services.Interfaces
{
    public interface IStockKeepUnitService
    {
        IEnumerable<StockKeepUnitVm> GetStockKeepUnits(Expression<Func<StockKeepUnit, bool>> filterPredicate = null);
        StockKeepUnitVm GetStockKeepUnit(Expression<Func<StockKeepUnit, bool>> filterPredicate = null);
        void AddOrUpdateStockKeepUnit(StockKeepUnitVm stockKeepUnitVm);
    }
}
