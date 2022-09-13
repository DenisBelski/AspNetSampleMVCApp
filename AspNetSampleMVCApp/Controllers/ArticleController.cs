using AspNetSample.Business.ServicesImplementations;
using AspNetSample.Core;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AspNetSampleMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Serilog.Events;

namespace AspNetSampleMvcApp.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private int _pageSize = 5;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        
        public async Task<IActionResult> Index(int page)
        {
            try
            {
                var articles = await _articleService
                    .GetArticlesByPageNumberAndPageSizeAsync(page, _pageSize);

                //HttpContext.RequestServices.GetServices(typeof(IArticleService)); - иногда применяется, сейчас считается антипаттерном

                if (articles.Any())
                {
                    return View(articles);
                }
                else
                {
                    throw new ArgumentException(nameof(page));
                }
            }
            catch (Exception e)
            {
                Log.Error($"{e.Message}. {Environment.NewLine} {e.StackTrace}");
                return BadRequest();
            }
        }

        // контоллеры для PartialView не нужны! (без этого блока также работает)
        //public IActionResult ArticlePreview(ArticleDto dto)
        //{
        //    return PartialView(dto);
        //}

        public async Task<IActionResult> Details(Guid id)
        {
            var dto = await _articleService.GetArticleByIdAsync(id);

            if (dto != null)
            {
                //ViewData["model"] = dto;
                //ViewBag.Model = dto;

                return View(dto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TestModel model)
        {
            return Ok();
        }

    }
}
