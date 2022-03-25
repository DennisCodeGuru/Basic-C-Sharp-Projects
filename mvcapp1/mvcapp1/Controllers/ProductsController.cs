using Microsoft.AspNetCore.Mvc;

namespace mvcapp1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
