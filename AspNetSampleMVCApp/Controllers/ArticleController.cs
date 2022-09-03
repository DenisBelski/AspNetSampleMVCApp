using AspNetSample.Business.ServicesImplementations;
using AspNetSample.Core;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AspNetSampleMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleMVCApp.Controllers
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
            // var articles = Articles.ArticlesList
            //    .Skip(page * _pageSize)
            //    .Take(_pageSize)
            //    .ToList();
            // return View(articles);

            try
            {
                var articles = await _articleService
                    .GetArticlesPageNumberAndPageSizeAsync(page, _pageSize);

                //HttpContext.RequestServices.GetServices(typeof(IArticleService)); - иногда применяется, сейчас считается антипаттерном

                if (articles.Any())
                {
                    return View(articles);
                }
                else
                {
                    return View("NoArticles");
                }
            }
            catch (Exception e)
            {
                // logger
                throw;
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
