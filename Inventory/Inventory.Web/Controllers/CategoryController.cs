using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.BLL.Entities;
using Inventory.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Core.Interfaces.UoW;
using Microsoft.Extensions.Logging;
using Inventory.ViewModels;

namespace Inventory.Web.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;
        //private readonly UserManager<User> _userManager;
        public CategoryController(ICategoryService categoryService, 
                                    UserManager<User> userManager,
                                    IUnitOfWork uow,
                                    ILoggerFactory loggerFactory) : base(uow, loggerFactory)
        {
            //_userManager = userManager;
            _categoryService = categoryService;
        }


        public IActionResult Index()
        {
            IEnumerable<CategoryVm> categoryVm = _categoryService.GetCategories();
            //if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
            //    return PartialView(categoryVm);
            //else
                return View(categoryVm);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(CategoryVm categoryVm)
        {
            if(ModelState.IsValid)
            {
                _categoryService.AddOrUpdateCategory(categoryVm);
                return RedirectToAction("Index");
            }
            else
                return View(ModelState);
        }
    }
}