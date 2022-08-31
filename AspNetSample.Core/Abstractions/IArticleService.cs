using AspNetSample.Core.DataTransferObjects;

namespace AspNetSample.Core.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetArticlesPageNumberAndPageSizeAsync(int pageNumber, int pageSize);
        Task<List<ArticleDto>> GetArticlesPageNumberAndPageSizeAsync();
    }
}
