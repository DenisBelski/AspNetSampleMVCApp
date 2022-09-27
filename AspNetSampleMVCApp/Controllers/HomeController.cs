using AspNetSampleMvcApp.Filters;
using AspNetSampleMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetSampleMvcApp.Controllers
{
    //[CustomActionFilter]
    [InternetExplorerBlockerFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AddDataToResponseHeaderFilter]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Privacy")]
        [HappyExceptionFilter("You'll read privacy policy in future.")]
        public IActionResult Privacy()
        {
            //var x = 0;
            //var z = 15 / x;

            return View();
        }

        public string About()
        {
            var str = "Test Asp.Net MVC Application with string response";
            return str;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}