using AspNetSample.DataBase;
using AspNetSample.DataBase.Entities;
using AspNetSample.Data.Abstractions;
using AspNetSample.Data.Abstractions.Repositories;

namespace AspNetSample.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GoodNewsAggregatorContext _database;

        public IAdditionalArticleRepository Articles { get; }
        public IRepository<Source> Sources { get; }

        public UnitOfWork(GoodNewsAggregatorContext database,
            IAdditionalArticleRepository articleRepository,
            IRepository<Source> sourceRepository)
        {
            _database = database;
            Articles = articleRepository;
            Sources = sourceRepository;
        }

        public async Task<int> Commit()
        {
            return await _database.SaveChangesAsync();
        }
    }
}
