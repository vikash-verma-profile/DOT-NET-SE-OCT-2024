using Ecommerce.Webapp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Ecommerce.Webapp.Models.ResponseModel;

namespace Ecommerce.Webapp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult SubmitLogin(Login login)
        {
            HttpClient client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(login),System.Text.Encoding.UTF8,"application/json");
            var response=client.PostAsync("https://localhost:7152/login", content).Result.Content.ReadAsStringAsync().Result;
            LoginResponseModel responseModel = JsonConvert.DeserializeObject<LoginResponseModel>(response);

            if (responseModel.IsLogin)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return View("Index");
            
        }
        public IActionResult SubmitRegister(Login login)
        {
            HttpClient client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(login), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:7152/register", content).Result.Content.ReadAsStringAsync().Result;
            LoginResponseModel responseModel = JsonConvert.DeserializeObject<LoginResponseModel>(response);

            return RedirectToAction("Index", "Login");
        }
    }
}
