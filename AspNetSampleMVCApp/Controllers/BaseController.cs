using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleMVCApp.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Context()
        {
            return Ok();
        }
    }
}
