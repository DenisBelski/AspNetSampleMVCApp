using AspNetSampleMVCApp.Models;
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

        [HttpGet]
        public string Test(int number)
        {
            return $"{number} * {number} = {number * number}";
        }

        [HttpGet]
        public string Test2(TestModel model)
        {
            return $"{model.Id}: {model.Name} : {model.Age}";
        }

        [HttpPost]
        public IActionResult FillTest(TestModel model)
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult TypesOfResponses()
        {
            // return new ContentResult(); or Content("") - return string
            // return new EmptyResult(); - 200 - equuivalent of void Action in controller
            // return NoContent(); - 204
            // return File(); - file result (download file)
            // return FileStreamResult(); 
            // return View();
            // return RedirectToAction(); - Redirect family
            // return StatusCode(513, "");
            // return Unauthorized();
            return Ok();
            // return NotFound();
            // return BadRequest();
        }

    }
}
