using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleMVCApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var cat = new
            {
                Name = "Vasily",
                Age = 18,
            };

            return Ok(cat);
        }

        [ActionName("Do")]
        public string DoSpecificThing()
        {
            return "cat Vasily";
        }
    }
}
