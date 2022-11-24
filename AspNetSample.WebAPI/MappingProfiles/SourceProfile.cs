using AspNetSample.Core.DataTransferObjects;
using AspNetSample.DataBase.Entities;
using AutoMapper;

namespace AspNetSample.Mappers.MappingProfiles;

public class SourceProfile : Profile
{
    public SourceProfile()
    {
        CreateMap<Source, SourceDto>();
        CreateMap<SourceDto, Source>();
    }
}