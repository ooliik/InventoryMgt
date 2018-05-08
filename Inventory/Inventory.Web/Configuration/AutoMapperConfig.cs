using AutoMapper;
using Inventory.BLL.Entities;
using Inventory.ViewModels;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inventory.Web.Configuration
{
    public static class AutoMapperConfig
    {
        public static IMapperConfigurationExpression Mapping(this IMapperConfigurationExpression configurationExpression, UserManager<User> userManager)
        {
            Mapper.Initialize(mapper =>
            {
                // Maps
                mapper.CreateMap<User, BaseUserVm>()
                    .ForMember(dest => dest.Roles, member => member.MapFrom(src =>
                         userManager.GetRolesAsync(src).Result
                    ));
                mapper.CreateMap<CategoryVm, Category>();
                mapper.CreateMap<Category, CategoryVm>();
                mapper.CreateMap<ItemVm, Item>();
                mapper.CreateMap<Item, ItemVm>();
                mapper.CreateMap<CustomerVm, Customer>();
                mapper.CreateMap<Customer, CustomerVm>();
                mapper.CreateMap<VendorVm, Vendor>();
                mapper.CreateMap<Vendor, VendorVm>();
                mapper.CreateMap<ItemStockKeepUnitVm, ItemStockKeepUnit>();
                mapper.CreateMap<ItemStockKeepUnit, ItemStockKeepUnitVm>();
                mapper.CreateMap<StockKeepUnitVm, StockKeepUnit>();
                mapper.CreateMap<StockKeepUnit, StockKeepUnitVm>();
                mapper.CreateMap<WarehouseVm, Warehouse>();
                mapper.CreateMap<Warehouse, WarehouseVm>();
                mapper.CreateMap<WarehouseEntryVm, WarehouseEntry>();
                mapper.CreateMap<WarehouseEntry, WarehouseEntryVm>();
                mapper.CreateMap<WarehousePlaceVm, WarehousePlace>();
                mapper.CreateMap<WarehousePlace, WarehousePlaceVm>();
            });
            return configurationExpression;
        }
    }
}
