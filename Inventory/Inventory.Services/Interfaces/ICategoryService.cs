using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Inventory.BLL.Entities;
using Inventory.ViewModels;
using System.Text;

namespace Inventory.Services.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryVm> GetCategories(Expression<Func<Category, bool>> filterPredicate = null);
        CategoryVm GetCategory(Expression<Func<Category, bool>> filterPredicate = null);
        void AddOrUpdateCategory(CategoryVm categoryVm);
        void DeleteCategory(CategoryVm categoryVm);
    }
}
