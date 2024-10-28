using DemoApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("/login")]
        public IActionResult Login(Login login)
        {
            ProductDbContext dbContext = new ProductDbContext();
            if (dbContext.Logins.Any(x => x.UserName == login.UserName && x.Password == login.Password))
            {
                return Ok(new { IsLogin = true, Message = "user authenticated successfully" });
            }
            else
            {
                return Ok(new { IsLogin = false, Message = "either username/password is incorrect." });
            }
        }
        [HttpPost]
        [Route("/register")]
        public IActionResult Register(Login login)
        {
            ProductDbContext dbContext = new ProductDbContext();
            dbContext.Logins.Add(login);
            dbContext.SaveChanges();
            return Ok(new {Message="user is registered successfully !"});
        }
    }
}
