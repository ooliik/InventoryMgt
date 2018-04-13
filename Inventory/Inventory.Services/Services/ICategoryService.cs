using Inventory.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Inventory.Services.Services
{
   public interface ICategoryService
    {
        IEnumerable<Category> GetPosts(Expression<Func<Category, bool>> filterPredicate = null);
        Category GetPost(Expression<Func<Category, bool>> filterPredicate = null);
        void AddOrUpdateCategory(AddCategory category);

    }
}
