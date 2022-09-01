using AspNetSample.Core;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;

namespace AspNetSample.Business.ServicesImplementations
{
    public class ArticleService : IArticleService
    {
        private readonly ArticlesStorage _articlesStorage;
        public ArticleService(ArticlesStorage articlesStorage)
        {
            _articlesStorage = articlesStorage;
        }

        public async Task<ArticleDto> GetArticleByIdAsync(Guid id)
        {
            var dto = _articlesStorage.ArticlesList
                .FirstOrDefault(ArticleDto => ArticleDto.Id.Equals(id));

            return dto;
        }

        public async Task<List<ArticleDto>> GetArticlesPageNumberAndPageSizeAsync(int pageNumber, int pageSize)
        {
            List<ArticleDto> list;

            list = _articlesStorage.ArticlesList
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .ToList();

            return list;
        }

        public async Task<List<ArticleDto>> GetArticlesPageNumberAndPageSizeAsync()
        {
            List<ArticleDto> list = new List<ArticleDto>();
            return list;
        }
    }
}
