using AspNetSample.Data.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;

namespace AspNetSampleMvcApp.Filters
{
    public class ArticleCheckerActionFilter : Attribute, IActionFilter
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArticleCheckerActionFilter(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                var id = (Guid)context.ActionArguments["id"];
                if (id.Equals(Guid.Empty))
                {
                    var randomId = _unitOfWork.Articles.Get().FirstOrDefault().Id;
                    context.ActionArguments["id"] = randomId;
                }
            }
            catch (Exception e)
            {
                Log.Error("Incorrect guid was used for article checker");
                throw;
            }

        }

        public void OnActionExecuted(ActionExecutedContext context)
        {


        }
    }
}
