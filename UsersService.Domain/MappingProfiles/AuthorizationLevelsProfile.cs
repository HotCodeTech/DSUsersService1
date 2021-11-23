using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Domain.Dtos;
using UsersService.Domain.Dtos.AuthorizationDtos;
using UsersService.Domain.Models;

namespace UsersService.Domain.MappingProfiles
{
    public class AuthorizationLevelsProfile : Profile
    {
        public AuthorizationLevelsProfile()
        {
            CreateMap<AuthorizationLevel, AuthorizationLevelReadDto>();
            CreateMap<AuthorizationLevelReadDto, AuthorizationLevel>();
            CreateMap<AuthorizationLevel, AuthorizationLevelCreateDto>();
            CreateMap<AuthorizationLevelCreateDto, AuthorizationLevel>();
            CreateMap<AuthorizationLevelCreateDto, AuthorizationLevelEntity>();
            CreateMap<AuthorizationLevelEntity, AuthorizationLevelCreateDto>();
            CreateMap<AuthorizationLevelReadDto, AuthorizationLevelEntity>();
            CreateMap<AuthorizationLevelEntity, AuthorizationLevelReadDto>();
            CreateMap<AuthorizationLevel, AuthorizationLevelEntity>();
            CreateMap<AuthorizationLevelEntity, AuthorizationLevel>();
            CreateMap<AuthorizationLevelCreateDto, AuthorizationLevelReadDto>();
            CreateMap<AuthorizationLevelReadDto, AuthorizationLevelCreateDto>();
            CreateMap<AuthorizationLevelUpdateDto, AuthorizationLevelCreateDto>();
            CreateMap<AuthorizationLevelCreateDto, AuthorizationLevelUpdateDto>();
            CreateMap<AuthorizationLevelUpdateDto, AuthorizationLevelReadDto>();
            CreateMap<AuthorizationLevelReadDto, AuthorizationLevelUpdateDto>();
            CreateMap<AuthorizationLevelUpdateDto, AuthorizationLevel>();
            CreateMap<AuthorizationLevel, AuthorizationLevelUpdateDto>();
            CreateMap<AuthorizationLevelUpdateDto, AuthorizationLevelEntity>();
            CreateMap<AuthorizationLevelEntity, AuthorizationLevelUpdateDto>();


        }
    }
}
