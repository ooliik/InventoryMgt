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
    public class StockKeepUnitService : BaseService, IStockKeepUnitService
    {
        public StockKeepUnitService(IUnitOfWork uow) : base(uow)
        {
        }

        public void AddOrUpdateStockKeepUnit(StockKeepUnitVm stockKeepUnitVm)
        {
            var stockKeepUnit = Mapper.Map<StockKeepUnit>(stockKeepUnitVm);
            _uow.Repository<StockKeepUnit>().AddOrUpdate(x => x.Code == stockKeepUnit.Code, stockKeepUnit);
            _uow.Save();
        }

        public StockKeepUnitVm GetStockKeepUnit(Expression<Func<StockKeepUnit, bool>> filterPredicate = null)
        {
            StockKeepUnit stockKeepUnit = _uow.Repository<StockKeepUnit>().Get(filterPredicate, false, null);
            StockKeepUnitVm stockKeepUnitVm = Mapper.Map<StockKeepUnitVm>(stockKeepUnit);
            return stockKeepUnitVm;
        }

        public IEnumerable<StockKeepUnitVm> GetStockKeepUnits(Expression<Func<StockKeepUnit, bool>> filterPredicate = null)
        {
            IEnumerable<StockKeepUnit> stockKeepUnits = _uow.Repository<StockKeepUnit>().GetRange(filterPredicate,
               false,
               x => x.OrderByDescending(p => p.Code), null, null, null);
            IEnumerable<StockKeepUnitVm> stockKeepUnitVm = Mapper.Map<IEnumerable<StockKeepUnitVm>>(stockKeepUnits);
            return stockKeepUnitVm;
        }
    }
}
