using Microsoft.AspNetCore.Mvc;
using Muhasebe.BusinessLayer.Concrete;
using Muhasebe.DataAccessLayer.EntityFramework;

namespace Muhasebe.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager = new CustomerManager(new EfCustomerRepository());
        public IActionResult Index()
        {
            //var values=_customerManager.GetAll();

            int companyId = 1;

            var values=_customerManager.GetAllByCompanyId(companyId);
            return View(values);
        }
    }
}
