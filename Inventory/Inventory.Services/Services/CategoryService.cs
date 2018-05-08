
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
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(IUnitOfWork uow) : base(uow)
        {
        }
        public void AddOrUpdateCategory(CategoryVm categoryVm)
        {
            var category = Mapper.Map<Category>(categoryVm);
            _uow.Repository<Category>().AddOrUpdate(x => x.CategoryID == category.CategoryID, category);
            _uow.Save();
           
        }

        public IEnumerable<CategoryVm> GetCategories(Expression<Func<Category, bool>> filterPredicate = null)
        {
            IEnumerable<Category> categories =  _uow.Repository<Category>().GetRange(filterPredicate,
                false,
                x => x.OrderByDescending(p => p.CategoryID), null, null, null);
            IEnumerable<CategoryVm> categoryVm = Mapper.Map<IEnumerable<CategoryVm>>(categories);
            return categoryVm;
        }

        public CategoryVm GetCategory(Expression<Func<Category, bool>> filterPredicate = null)
        {
            Category category = _uow.Repository<Category>().Get(filterPredicate, false,null);
            CategoryVm categoryVm = Mapper.Map<CategoryVm>(category);
            return categoryVm;
        }
        public void DeleteCategory(CategoryVm categoryVm)
        {
            //var category = Mapper.Map<Category>(categoryVm);
            //Category caategory;
            
            var category = _uow.Repository<Category>().Get(x => x.CategoryID == categoryVm.CategoryID);
            _uow.Repository<Category>().Delete(category);
            _uow.Save();

        }

    }
}
