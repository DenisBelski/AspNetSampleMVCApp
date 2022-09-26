using AspNetSample.Data.Abstractions.Repositories;
using AspNetSample.DataBase;
using AspNetSample.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetSample.Data.Repositories
{
    public class ArticleRepository : IArticleRepository //-> CRUD operations with Articles Table in DB
    {
        private readonly GoodNewsAggregatorContext _database;

        public ArticleRepository(GoodNewsAggregatorContext database)
        {
            _database = database;
        }

        public async Task<Article?> GetArticleByIdAsync(Guid id)
        {
            return await _database
                .Articles.FirstOrDefaultAsync(article => article.Id.Equals(id));
        }

        //not for regular usage
        public IQueryable<Article> GetArticlesAsQueryable()
        {
            return _database.Articles;
        }

        public async Task<List<Article?>> GetAllArticlesAsync()
        {
            return await _database.Articles.ToListAsync();
        }

        public async Task AddArticleAsync(Article article)
        {
            await _database.Articles.AddAsync(article);
        }

        public async Task AddArticlesAsync(IEnumerable<Article> articles)
        {
            await _database.Articles.AddRangeAsync(articles);
        }

        public async Task RemoveArticleAsync(Article article)
        {
            _database.Articles.Remove(article);
        }

        public async Task UpdateArticle(Guid id, Article article)
        {
            var entity = await _database.Articles.FirstOrDefaultAsync(article => article.Id.Equals(id));

            if (entity != null)
            {
                entity = article;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _database.SaveChangesAsync();
        }
    }
}