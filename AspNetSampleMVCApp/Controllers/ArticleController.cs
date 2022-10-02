using AspNetSample.Business.ServicesImplementations;
using AspNetSample.Core;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AspNetSampleMvcApp.Filters;
using AspNetSampleMvcApp.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Serilog.Events;

namespace AspNetSampleMvcApp.Controllers
{
    [Authorize(Roles = "User")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;
        private int _pageSize = 5;

        public ArticleController(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
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

        [TypeFilter(typeof(ArticleCheckerActionFilter))]
        //[ServiceFilter(typeof(ArticleCheckerActionFilter))] -> registred filter in DI
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
        public async Task<IActionResult> Create()
        {
            //var model = new CreateArticleModel();
            //var sources = await _sourceService.GetSourcesAsync();
            //model.Sources = sources
            //    .Select(dto => new SelectListItem(
            //        dto.Name,
            //        dto.Id.ToString("G")))
            //    .ToList();
            //return View(model);

            return View();
            //return View("CreateOrEdit", new CreateOrEditModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ArticleModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // часть серверной валидации, см. также DataAnnotations
                    if (model.Title.ToUpperInvariant().Contains("123"))
                    {
                        ModelState.AddModelError("Title", "Article contains 123");
                        return View(model);
                    }

                    model.Id = Guid.NewGuid();
                    model.PublicationDate = DateTime.Now;

                    var dto = _mapper.Map<ArticleDto>(model);

                    await _articleService.CreateArticleAsync(dto);

                    return RedirectToAction("Index", "Article");
                }

                else
                {
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id != Guid.Empty)
            {
                var articleDto = await _articleService.GetArticleByIdAsync(id);
                if (articleDto == null)
                {
                    return BadRequest();
                }

                var editModel = _mapper.Map<ArticleModel>(articleDto);

                //returt View("CreateOrEdit", editModel);
                return View(editModel);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ArticleModel model)
        {
            try
            {
                if (model != null)
                {
                    var dto = _mapper.Map<ArticleDto>(model);

                    var sourceDto = await _articleService.GetArticleByIdAsync(model.Id);

                    //should be sure that dto property naming is the same with entity property naming
                    var patchList = new List<PatchModel>();
                    if (dto != null)
                    {
                        if (dto.Title.Equals(sourceDto.Title))
                        {
                            patchList.Add(new PatchModel()
                            {
                                PropertyName = nameof(dto.Title),
                                PropertyValue = dto.Title
                            });
                        }
                    }

                    await _articleService.PatchAsync(model.Id, patchList);

                    //await _articleService.CreateArticleAsync(dto);

                    return RedirectToAction("Index", "Article");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok();
        }

    }
}
