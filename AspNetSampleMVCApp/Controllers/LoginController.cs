using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleMVCApp.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Register() => Ok("Registred");

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            return Ok("logged in");
        }
    }
}
