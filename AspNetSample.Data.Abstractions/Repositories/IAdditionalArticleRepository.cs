using AspNetSample.DataBase.Entities;

namespace AspNetSample.Data.Abstractions.Repositories
{
    public interface IAdditionalArticleRepository : IRepository<Article>
    {
        Task UpdateArticleTextAsync(Guid id, string text);
    }
}
