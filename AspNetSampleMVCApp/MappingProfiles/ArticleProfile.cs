using AspNetSample.DataBase.Entities;
using AspNetSample.Core.DataTransferObjects;
using AutoMapper;
using AspNetSampleMvcApp.Models;

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

        CreateMap<ArticleDto, Article>()
            .ForMember(dto => dto.FullText,
                opt => opt.MapFrom(article => article.Text))
            .ForMember(article => article.ShortDescription, 
                opt => opt.MapFrom(article => article.ShortSummary))
            .ForMember(article => article.SourceId, 
                opt => opt.MapFrom(article => new Guid("2F5A053B-2344-471B-AD99-5768483DD535")));

        CreateMap<ArticleDto, ArticleModel>().ReverseMap();
    }
}