using AspNetSample.Core.DataTransferObjects;
using AspNetSample.DataBase.Entities;
using AutoMapper;

namespace AspNetSample.Mappers
{
    public class SourceProfile : Profile
    {
        public SourceProfile()
        {
            CreateMap<Source, SourceDto>();
            CreateMap<SourceDto, Source>();


            //non good practice basically, but can be used sometimes
            //CreateMap<CreateSourceModel, SourceDto>()
            //    .ForMember(dto => dto.Id,
            //    opt => opt.MapFrom(article => Guid.NewGuid()));



            //CreateMap<SourceModel, SourceDto>();
            //CreateMap<SourceDto, SourceModel>();
        }
    }
}