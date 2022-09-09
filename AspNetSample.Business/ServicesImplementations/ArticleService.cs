using AspNetSample.DataBase;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AspNetSample.Business.ServicesImplementations;

public class ArticleService : IArticleService
{
    private readonly IMapper _mapper;
    private readonly GoodNewsAggregatorContext _databaseContext;

    public ArticleService(GoodNewsAggregatorContext databaseContext,
        IMapper mapper)
    {
        _databaseContext = databaseContext;
        _mapper = mapper;
    }


    public async Task<List<ArticleDto>> GetArticlesByPageNumberAndPageSizeAsync(int pageNumber, int pageSize)
    {
        var list = await _databaseContext.Articles
            .Skip(pageNumber * pageSize)
            .Take(pageSize)
            .Select(article => _mapper.Map<ArticleDto>(article))
            .ToListAsync();

        return list;
    }

    public async Task<List<ArticleDto>> GetNewArticlesFromExternalSourcesAsync()
    {
        var list = new List<ArticleDto>();
        return list;
    }

    public async Task<ArticleDto> GetArticleByIdAsync(Guid id)
    {
        var dto = new ArticleDto();
        //_articlesStorage.ArticlesList
        //.FirstOrDefault(articleDto => articleDto.Id.Equals(id));

        return dto;
    }
}