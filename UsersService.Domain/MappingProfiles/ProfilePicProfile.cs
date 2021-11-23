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
    public class ProfilePicProfile : Profile
    {
        public ProfilePicProfile()
        {
            // Source -> Target.
            CreateMap<ProfilePicCreateDto, ProfilePicReadDto>();
            CreateMap<ProfilePicReadDto, ProfilePicCreateDto>();
            CreateMap<ProfilePicCreateDto, ProfilePicEntity>();
            CreateMap<ProfilePicEntity, ProfilePicCreateDto>();
            CreateMap<ProfilePicReadDto, ProfilePicEntity>();
            CreateMap<ProfilePicEntity, ProfilePicReadDto>();
            CreateMap<ProfilePicCreateDto, ProfilePic>();
            CreateMap<ProfilePic, ProfilePicCreateDto>();
            CreateMap<ProfilePicReadDto, ProfilePic>();
            CreateMap<ProfilePic, ProfilePicReadDto>();
            CreateMap<ProfilePicEntity, ProfilePic>();
            CreateMap<ProfilePic, ProfilePicEntity>();
            CreateMap<ProfilePicUpdateDto, ProfilePicEntity>();
            CreateMap<ProfilePicEntity, ProfilePicUpdateDto>();
            CreateMap<ProfilePicUpdateDto, ProfilePic>();
            CreateMap<ProfilePic, ProfilePicUpdateDto>();
            CreateMap<ProfilePicUpdateDto, ProfilePicCreateDto>();
            CreateMap<ProfilePicCreateDto, ProfilePicUpdateDto>();
            CreateMap<ProfilePicUpdateDto, ProfilePicReadDto>();
            CreateMap<ProfilePicReadDto, ProfilePicUpdateDto>();




        }
    }
}
