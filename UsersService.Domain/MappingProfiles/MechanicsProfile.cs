using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Domain.Dtos.UserDtos.MechanicDtos;
using UsersService.Domain.Models;

namespace UsersService.Domain.MappingProfiles
{
    public class MechanicsProfile : Profile
    {
        public MechanicsProfile()
        {
            // Source -> Target
            CreateMap<MechanicCreateDto, User>();
            CreateMap<User, MechanicCreateDto>();
            CreateMap<User, MechanicReadDto>();
            CreateMap<MechanicReadDto, User>();
            CreateMap<UserEntity, MechanicReadDto>();
            CreateMap<MechanicReadDto, UserEntity>();
            CreateMap<UserEntity, MechanicCreateDto>();
            CreateMap<MechanicCreateDto, UserEntity>();
            CreateMap<UserEntity, User>();
            CreateMap<User, UserEntity>();
            CreateMap<MechanicCreateDto, MechanicReadDto>();
            CreateMap<MechanicReadDto, MechanicCreateDto>();
            CreateMap<MechanicUpdateDto, MechanicCreateDto>();
            CreateMap<MechanicCreateDto, MechanicUpdateDto>();
            CreateMap<MechanicUpdateDto, MechanicReadDto>();
            CreateMap<MechanicReadDto, MechanicUpdateDto>();
            CreateMap<MechanicUpdateDto, User>();
            CreateMap<User, MechanicUpdateDto>();
            CreateMap<MechanicUpdateDto, UserEntity>();
            CreateMap<UserEntity, MechanicUpdateDto>();
        }
    }
}
