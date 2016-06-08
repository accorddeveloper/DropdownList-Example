using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using DropdownList_Example.Models;

namespace DropdownList_Example.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var model = new CategoryViewModel();

            // using Model
            model.CategoryList = new SelectList(GetAllCategories(), "Id", "CategoryName");

            // using ViewBag
            ViewBag.VBCategoryList = new SelectList(GetAllCategories(), "Id", "CategoryName");


            return View(model);
        }

        public List<CategoryViewModel> GetAllCategories()
        {
            var categories = new List<CategoryViewModel>
            {
                new CategoryViewModel {Id = 1, CategoryName = "SmartPhone"},
                new CategoryViewModel {Id = 2, CategoryName = "Tablet"},
                new CategoryViewModel {Id = 3, CategoryName = "Laptop"},
                new CategoryViewModel {Id = 4, CategoryName = "SmartWatch"}
            };

            return categories.ToList();
        }
    }
}