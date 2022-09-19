using AspNetSample.DataBase;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AspNetSample.DataBase.Entities;

namespace AspNetSample.Business.ServicesImplementations;

public class ArticleService : IArticleService
{
    private readonly IMapper _mapper;
    private readonly GoodNewsAggregatorContext _databaseContext;
    private readonly IConfiguration _configuration;

    public ArticleService(GoodNewsAggregatorContext databaseContext,
        IMapper mapper,
        IConfiguration configuration)
    {
        _databaseContext = databaseContext;
        _mapper = mapper;
        _configuration = configuration;
    }

    public async Task<List<ArticleDto>> GetArticlesByPageNumberAndPageSizeAsync(int pageNumber, int pageSize)
    {
        try
        {
            var myApiDey = _configuration.GetSection("UserSecrets")["MyApiKey"];
            var passwordSalt = _configuration["UserSecrets:PasswordSalt"];

            var list = await _databaseContext.Articles
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .Select(article => _mapper.Map<ArticleDto>(article))
                .ToListAsync();

            return list;
        }
        catch (Exception)
        {
            // todo add logger here
            throw;
        }
    }

    public async Task<List<ArticleDto>> GetNewArticlesFromExternalSourcesAsync()
    {
        var list = new List<ArticleDto>();
        return list;
    }

    public async Task<ArticleDto> GetArticleByIdAsync(Guid id)
    {
        var entity = await _databaseContext.Articles.FirstOrDefaultAsync(article => article.Id.Equals(id));
        var dto = _mapper.Map<ArticleDto>(entity);

        return dto;
    }

    public async Task<int> CreateArticleAsync(ArticleDto dto)
    {
        var entity = _mapper.Map<Article>(dto);

        if (entity != null)
        {
            await _databaseContext.Articles.AddAsync(entity);
            var addingResult = await _databaseContext.SaveChangesAsync();
            return addingResult;
        }
        else
        {
            throw new ArgumentException(nameof(dto));
        }
    }
}