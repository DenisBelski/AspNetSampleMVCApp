using AspNetSample.Core.DataTransferObjects;
using AspNetSample.DataBase.Entities;
using AutoMapper;

namespace AspNetSample.Mappers.MappingProfiles;

public class ArticleProfile : Profile
{
    public ArticleProfile()
    {
        CreateMap<Article, ArticleDto>()
            .ForMember(dto => dto.Id,
                opt => opt.MapFrom(article => article.Id))
            .ForMember(dto => dto.Text,
                opt => opt.MapFrom(article => article.Text))
            .ForMember(dto => dto.Category,
                opt => opt.MapFrom(article => "Default"));

        CreateMap<ArticleDto, Article>()
            .ForMember(dto => dto.Text,
                opt => opt.MapFrom(article => article.Text))
            .ForMember(article => article.ShortSummary,
                opt => opt.MapFrom(article => article.ShortSummary))
            .ForMember(article => article.SourceId,
                opt => opt.MapFrom(article => new Guid("2F5A053B-2344-471B-AD99-5768483DD535")));
    }
}