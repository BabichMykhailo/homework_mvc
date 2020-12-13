using BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_A_LEVEL.Models.Category;

namespace WebApplication_A_LEVEL.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private readonly CategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }
        public ActionResult MyCategories()
        {
            //List<CategoryBl> model = _categoryService.GetMyCategories();
            CategoryModel model = new CategoryModel
            {
                Id = 1,
                Title = "tets"
                
            };

            return View("/Views/Category/MyCategories.cshtml", model);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}