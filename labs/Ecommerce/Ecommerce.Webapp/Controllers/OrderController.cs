using Ecommerce.Webapp.Models;
using Ecommerce.Webapp.Models.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Ecommerce.Webapp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index(int id)
        {
            HttpClient client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(new OrderViewModel { Id=id}), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:7152/send-order", content).Result.Content.ReadAsStringAsync().Result;


            return View();
        }

    }
}
