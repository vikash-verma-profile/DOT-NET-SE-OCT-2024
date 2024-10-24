using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
