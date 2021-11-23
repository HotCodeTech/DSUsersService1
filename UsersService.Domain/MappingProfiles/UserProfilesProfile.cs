using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Domain.Dtos;
using UsersService.Domain.Dtos.ProfileDtos;
using UsersService.Domain.Models;

namespace UsersService.Domain.MappingProfiles
{
    class UserProfilesProfile : Profile
    {
        public UserProfilesProfile()
        {
            CreateMap<UserProfileCreateDto, UserProfile>();
            CreateMap<UserProfile, UserProfileCreateDto>();
            CreateMap<UserProfile, UserProfileReadDto>();
            CreateMap<UserProfileReadDto, UserProfile>();
            CreateMap<ProfileEntity, UserProfileReadDto>();
            CreateMap<UserProfileReadDto, ProfileEntity>();
            CreateMap<ProfileEntity, UserProfileCreateDto>();
            CreateMap<UserProfileCreateDto, ProfileEntity>();
            CreateMap<ProfileEntity, UserProfile>();
            CreateMap<UserProfile, ProfileEntity>();
            CreateMap<UserProfileCreateDto, UserProfileReadDto>();
            CreateMap<UserProfileReadDto, UserProfileCreateDto>();
            CreateMap<UserProfileUpdateDto, UserProfileCreateDto>();
            CreateMap<UserProfileCreateDto, UserProfileUpdateDto>();
            CreateMap<UserProfileUpdateDto, UserProfileReadDto>();
            CreateMap<UserProfileReadDto, UserProfileUpdateDto>();
            CreateMap<UserProfileUpdateDto, UserProfile>();
            CreateMap<UserProfile, UserProfileUpdateDto>();
            CreateMap<UserProfileUpdateDto, ProfileEntity>();
            CreateMap<ProfileEntity, UserProfileUpdateDto>();



        }
    }
}
