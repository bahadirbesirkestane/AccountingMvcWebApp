using Microsoft.AspNetCore.Mvc;
using Muhasebe.BusinessLayer.Concrete;
using Muhasebe.DataAccessLayer.EntityFramework;

namespace Muhasebe.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values=_categoryManager.GetAll();

            return View(values);
        }
    }
}
