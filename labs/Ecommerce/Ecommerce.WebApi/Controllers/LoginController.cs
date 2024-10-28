using Ecommerce.WebApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ProductDbContext _context;
        public LoginController(ProductDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("/login")]
        public IActionResult Login(Login login)
        {
            if (_context.Logins.Any(x => x.UserName == login.UserName && x.Password == login.Password))
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
            _context.Logins.Add(login);
            _context.SaveChanges();
            return Ok(new { Message = "user is registered successfully !" });
        }
    }
}
