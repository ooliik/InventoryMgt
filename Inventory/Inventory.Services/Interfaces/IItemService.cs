using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Inventory.BLL.Entities;
using Inventory.ViewModels;

namespace Inventory.Services.Interfaces
{
    public interface IItemService
    {
        IEnumerable<ItemVm> GetItems(Expression<Func<Item, bool>> filterPredicate = null);
        ItemVm GetItem(Expression<Func<Item, bool>> filterPredicate = null);
        void AddOrUpdateItem(ItemVm itemVm);
    }
}
