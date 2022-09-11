using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleMvcApp.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Home()
        {
            return BadRequest();
        }
    }
}
