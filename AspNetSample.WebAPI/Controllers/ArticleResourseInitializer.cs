using AspNetSample.Core.Abstractions;
using AspNetSample.WebAPI.Models.Responses;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleResourseInitializer : ControllerBase
    {

        private readonly IArticleService _articleService;
        private readonly ISourceService _sourceService;
        private readonly IMapper _mapper;

        public ArticleResourseInitializer(IArticleService articleService, 
            ISourceService sourceService, 
            IMapper mapper)
        {
            _articleService = articleService;
            _sourceService = sourceService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddArticles()
        {
            try
            {
                //RecurringJob.AddOrUpdate(() => _articleService.AggregateArticlesFromExternalSourcesAsync(),
                //    "5,10,35 10-18 * * Mon-Fri");

                //RecurringJob.RemoveIfExists(nameof(_articleService.AggregateArticlesFromExternalSourcesAsync));

                //RecurringJob.AddOrUpdate(()=>_articleService.GetAllArticleDataFromRssAsync(),
                //    "*/15 * * * *");
                //RecurringJob.AddOrUpdate(()=>_articleService.AddArticleTextToArticlesAsync(),
                //    "*/30 * * * *");
                
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorModel() { Message = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> RateArticles()
        {
            try
            {
                //await _articleService.AddRateToArticlesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorModel() { Message = ex.Message });
            }
        }
    }
}
