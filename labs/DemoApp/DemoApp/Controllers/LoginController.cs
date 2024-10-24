using DemoApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
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
            ProductDbContext dbContext = new ProductDbContext();
            if(dbContext.Logins.Any(x=>x.UserName==login.UserName && x.Password==login.Password))
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View("Index");
            }
         
        }
        public IActionResult SubmitRegister(Login login)
        {
            ProductDbContext dbContext = new ProductDbContext();
            dbContext.Logins.Add(login);
            dbContext.SaveChanges();
            return RedirectToAction("Index", "Login"); ;
        }
    }
}
