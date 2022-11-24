using AspNetSample.Core.DataTransferObjects;
using AspNetSample.DataBase.Entities;
using AutoMapper;

namespace AspNetSample.Mappers
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleDto>();

            CreateMap<ArticleDto, Article>();

            //CreateMap<ArticleDto, ArticleModel>().ReverseMap();
        }
    }
}