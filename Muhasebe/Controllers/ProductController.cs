using Microsoft.AspNetCore.Mvc;
using Muhasebe.BusinessLayer.Concrete;
using Muhasebe.DataAccessLayer.EntityFramework;

namespace Muhasebe.Controllers
{
    public class ProductController : Controller
    {
        ProductManager _productManager =new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            // Eager Loading
            
            int companyId = 1;
            int categoryId= 1;

            //var values = _productManager.GetAllByCategoryId(categoryId);

            // user.CompanyId kullanılacak
            var values = _productManager.GetProductListWithCategory(companyId);

            return View(values);
        }
    }
}
