using AspNetSample.DataBase.Entities;
using AspNetSample.Core.DataTransferObjects;
using AutoMapper;
using AspNetSampleMvcApp.Models;

namespace AspNetSampleMvcApp.MappingProfiles;

public class ArticleProfile : Profile
{
    public ArticleProfile()
    {
        CreateMap<Article, ArticleDto>();
        CreateMap<ArticleDto, Article>();

        CreateMap<ArticleDto, ArticleModel>().ReverseMap();
    }
}