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
            var values=_productManager.GetAll();

            return View(values);
        }
    }
}
