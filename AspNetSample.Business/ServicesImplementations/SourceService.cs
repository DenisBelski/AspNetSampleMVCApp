using AspNetSample.DataBase;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AspNetSample.DataBase.Entities;

namespace AspNetSample.Business.ServicesImplementations;

public class SourceService : ISourceService
{
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    private readonly GoodNewsAggregatorContext _databaseContext;

    public SourceService(GoodNewsAggregatorContext databaseContext,
        IMapper mapper,
        IConfiguration configuration)
    {
        _databaseContext = databaseContext;
        _mapper = mapper;
        _configuration = configuration;
    }

    public async Task<List<SourceDto>> GetSourcesAsync()
    {
        return await _databaseContext.Sources
            .Select(source => _mapper.Map<SourceDto>(source))
            .ToListAsync();
    }

    public async Task<SourceDto> GetSourcesByIdAsync(Guid id)
    {
        return _mapper.Map<SourceDto>(await _databaseContext.Sources
            .FirstOrDefaultAsync(source => source.Id.Equals(id)));
    }

    public async Task<int> CreateSourcesAsync(SourceDto dto)
    {
        var entity = _mapper.Map<Source>(dto);
        await _databaseContext.Sources.AddAsync(entity);
        return await _databaseContext.SaveChangesAsync();
    }
}