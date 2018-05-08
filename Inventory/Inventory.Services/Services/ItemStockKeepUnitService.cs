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
    public class ItemStockKeepUnitService : BaseService, IItemStockKeepUnitService
    {
        public ItemStockKeepUnitService(IUnitOfWork uow) : base(uow)
        {
        }

        public void AddItemStockKeepUnit(ItemStockKeepUnitVm itemStockKeepUnitVm)
        {
            var itemStockKeepUnit = Mapper.Map<ItemStockKeepUnit>(itemStockKeepUnitVm);
            _uow.Repository<ItemStockKeepUnit>().AddOrUpdate(x => x.Code == itemStockKeepUnit.Code, itemStockKeepUnit);
            _uow.Save();
        }

        public ItemStockKeepUnitVm GetItemStockKeepUnit(Expression<Func<ItemStockKeepUnit, bool>> filterPredicate = null)
        {
            ItemStockKeepUnit itemStockKeepUnit = _uow.Repository<ItemStockKeepUnit>().Get(filterPredicate, false, null);
            ItemStockKeepUnitVm itemStockKeepUnitVm = Mapper.Map<ItemStockKeepUnitVm>(itemStockKeepUnit);
            return itemStockKeepUnitVm;
        }

        public IEnumerable<ItemStockKeepUnitVm> GetItemStockKeepUnits(Expression<Func<ItemStockKeepUnit, bool>> filterPredicate = null)
        {
            IEnumerable<ItemStockKeepUnit> itemStockKeepUnits = _uow.Repository<ItemStockKeepUnit>().GetRange(filterPredicate,
                false,
                x => x.OrderByDescending(p => p.Code), null, null, null);
            IEnumerable<ItemStockKeepUnitVm> itemStockKeepUnitVm = Mapper.Map<IEnumerable<ItemStockKeepUnitVm>>(itemStockKeepUnits);
            return itemStockKeepUnitVm;
        }
    }
}
