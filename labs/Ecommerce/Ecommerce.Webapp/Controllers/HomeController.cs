using Ecommerce.Webapp.Models;
using Ecommerce.Webapp.Models.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Ecommerce.Webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://localhost:7152/api/Products").Result.Content.ReadAsStringAsync().Result;
            IEnumerable<Product> productList = JsonConvert.DeserializeObject<IEnumerable<Product>>(response);

            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
