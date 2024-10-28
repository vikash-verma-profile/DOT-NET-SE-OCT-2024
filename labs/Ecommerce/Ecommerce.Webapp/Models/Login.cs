using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Webapp.Models
{
    public class Login
    {
        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string? Password { get; set; }
    }
}
