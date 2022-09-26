using AspNetSample.DataBase.Entities;

namespace AspNetSample.Data.Abstractions.Repositories
{
    public interface IAdditionalArticleRepository : IRepository<Article>
    {
        void DoCustomMethod();
    }
}
