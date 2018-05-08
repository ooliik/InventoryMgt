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
    public class WarehousePlaceService : BaseService, IWarehousePlaceService
    {
        public WarehousePlaceService(IUnitOfWork uow) : base(uow)
        {
        }

        public void AddOrUpdateWarehousePlace(WarehousePlaceVm warehousePlaceVm)
        {
            var warehousePlace = Mapper.Map<WarehousePlace>(warehousePlaceVm);
            _uow.Repository<WarehousePlace>().AddOrUpdate(x => x.WarehousePlaceName == warehousePlace.WarehousePlaceName, warehousePlace);
            _uow.Save();
        }

        public WarehousePlaceVm GetWarehousePlace(Expression<Func<WarehousePlace, bool>> filterPredicate = null)
        {
            WarehousePlace warehousePlace = _uow.Repository<WarehousePlace>().Get(filterPredicate, false, null);
            WarehousePlaceVm warehousePlaceVm = Mapper.Map<WarehousePlaceVm>(warehousePlace);
            return warehousePlaceVm;
        }

        public IEnumerable<WarehousePlaceVm> GetWarehousePlaces(Expression<Func<WarehousePlace, bool>> filterPredicate = null)
        {
            IEnumerable<WarehousePlace> warehousePlaces = _uow.Repository<WarehousePlace>().GetRange(filterPredicate,
                false,
                x => x.OrderByDescending(p => p.WarehousePlaceName), null, null, null);
            IEnumerable<WarehousePlaceVm> warehousePlaceVm = Mapper.Map<IEnumerable<WarehousePlaceVm>>(warehousePlaces);
            return warehousePlaceVm;
        }
    }
}
