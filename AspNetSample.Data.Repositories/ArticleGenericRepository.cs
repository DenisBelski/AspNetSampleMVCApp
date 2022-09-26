using AspNetSample.Data.Abstractions.Repositories;
using AspNetSample.DataBase;
using AspNetSample.DataBase.Entities;

namespace AspNetSample.Data.Repositories
{
    public class ArticleGenericRepository : Repository<Article>, IAdditionalArticleRepository
    {
        public ArticleGenericRepository(GoodNewsAggregatorContext database)
            : base(database)
        {
        }

        public void DoCustomMethod()
        {
            throw new NotImplementedException();
        }
    }
}
