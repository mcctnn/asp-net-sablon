using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Contracts;

namespace StoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class CategoryController:Controller
    {
        private readonly IServiceManager _manager;

        public CategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Categories";
            var model= _manager.CategoryService.GetAllCategories(false);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = GetCategoriesSelectedList();


            return View();
        }

        private SelectList GetCategoriesSelectedList()
        {
            return new SelectList
            (_manager.CategoryService.GetAllCategories(false),
            "CategoryId", "CategoryName", "1");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([FromForm]CategoryDtoForInsertion categoryDto)
        {
            if(ModelState.IsValid)
            {
                _manager.CategoryService.CreateCategory(categoryDto);
                 return RedirectToAction("Index");
            }
            return View();
        }
    }
}