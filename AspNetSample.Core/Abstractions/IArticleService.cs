using AspNetSample.Core.DataTransferObjects;

namespace AspNetSample.Core.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetArticlesByPageNumberAndPageSizeAsync(int pageNumber, int pageSize);
        Task<List<ArticleDto>> GetNewArticlesFromExternalSourcesAsync();
        Task<ArticleDto> GetArticleByIdAsync(Guid id);
    }
}
