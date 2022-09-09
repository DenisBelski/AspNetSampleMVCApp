using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleMvcApp.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Context()
        {
            return Ok();
        }
    }
}
