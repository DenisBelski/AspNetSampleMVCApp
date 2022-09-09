using AspNetSample.DataBase.Entities;
using AspNetSample.Core.DataTransferObjects;
using AutoMapper;

namespace AspNetSampleMvcApp.MappingProfiles;

public class ArticleProfile : Profile
{
    public ArticleProfile()
    {
        CreateMap<Article, ArticleDto>()
            .ForMember(dto => dto.Id,
                opt => opt.MapFrom(article => article.Id))
            .ForMember(dto => dto.Text,
                opt => opt.MapFrom(article => article.FullText))
            .ForMember(dto => dto.Category,
                opt => opt.MapFrom(article => "Default"));
    }
}