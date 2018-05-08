using AutoMapper;
using DataAccessLayer.Core.Interfaces.UoW;
using Inventory.BLL.Entities;
using Inventory.Services.Interfaces;
using Inventory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Inventory.Services.Services
{
    public class ItemService : BaseService, IItemService
    {
        public ItemService(IUnitOfWork uow) : base(uow)
        {
        }
        public void AddOrUpdateItem(ItemVm itemVm)
        {
            var item = Mapper.Map<Item>(itemVm);
            _uow.Repository<Item>().AddOrUpdate(x => x.ItemID == item.ItemID, item);
            _uow.Save();
        }

        public ItemVm GetItem(Expression<Func<Item, bool>> filterPredicate = null)
        {
            Item item = _uow.Repository<Item>().Get(filterPredicate, false, null);
            ItemVm itemVm = Mapper.Map<ItemVm>(item);
            return itemVm;
        }

        public IEnumerable<ItemVm> GetItems(Expression<Func<Item, bool>> filterPredicate = null)
        {
            IEnumerable<Item> items = _uow.Repository<Item>().GetRange(filterPredicate,
                false,
                x => x.OrderByDescending(p => p.ItemID), null, null, null);
            IEnumerable<ItemVm> itemVm = Mapper.Map<IEnumerable<ItemVm>>(items);
            return itemVm;
        }
    }
}
