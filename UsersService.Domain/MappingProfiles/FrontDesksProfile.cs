using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Domain.Dtos.UserDtos.FrontDeskDtos;
using UsersService.Domain.Models;

namespace UsersService.Domain.MappingProfiles
{
    public class FrontDesksProfile : Profile
    {
        public FrontDesksProfile()
        {
            // Source -> Target
            CreateMap<FrontDeskCreateDto, User>();
            CreateMap<User, FrontDeskCreateDto>();
            CreateMap<User, FrontDeskReadDto>();
            CreateMap<FrontDeskReadDto, User>();
            CreateMap<UserEntity, FrontDeskReadDto>();
            CreateMap<FrontDeskReadDto, UserEntity>();
            CreateMap<UserEntity, FrontDeskCreateDto>();
            CreateMap<FrontDeskCreateDto, UserEntity>();
            CreateMap<UserEntity, User>();
            CreateMap<User, UserEntity>();
            CreateMap<FrontDeskCreateDto, FrontDeskReadDto>();
            CreateMap<FrontDeskReadDto, FrontDeskCreateDto>();
            CreateMap<FrontDeskUpdateDto, FrontDeskCreateDto>();
            CreateMap<FrontDeskCreateDto, FrontDeskUpdateDto>();
            CreateMap<FrontDeskUpdateDto, FrontDeskReadDto>();
            CreateMap<FrontDeskReadDto, FrontDeskUpdateDto>();
            CreateMap<FrontDeskUpdateDto, User>();
            CreateMap<User, FrontDeskUpdateDto>();
            CreateMap<FrontDeskUpdateDto, UserEntity>();
            CreateMap<UserEntity, FrontDeskUpdateDto>();
        }
    }
}
