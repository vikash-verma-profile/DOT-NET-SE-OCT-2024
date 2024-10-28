using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Webapp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
