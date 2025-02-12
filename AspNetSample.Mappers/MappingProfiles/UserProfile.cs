﻿using AspNetSample.Core.DataTransferObjects;
using AspNetSample.DataBase.Entities;
using AutoMapper;

namespace AspNetSample.Mappers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(dto => dto.RoleName,
                opt
                    => opt.MapFrom(entity => entity.Role.Name));

            CreateMap<UserDto, User>()
                .ForMember(ent => ent.Id,
                    opt
                        => opt.MapFrom(dto => Guid.NewGuid()))
                .ForMember(ent => ent.RegistrationDate,
                    opt
                        => opt.MapFrom(dto => DateTime.Now));

            //CreateMap<RegisterModel, UserDto>();

            //CreateMap<LoginModel, UserDto>();

        }
    }
}
