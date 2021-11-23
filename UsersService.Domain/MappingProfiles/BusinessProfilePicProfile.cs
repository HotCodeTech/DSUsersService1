using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Domain.Dtos.BusinessDtos;
using UsersService.Domain.Dtos.ProfileDtos;
using UsersService.Domain.Models;

namespace UsersService.Domain.MappingProfiles
{
    public class BusinessProfilePicProfile : Profile
    {
        public BusinessProfilePicProfile()
        {
            // Source -> Target.
            CreateMap<BusinessProfilePicCreateDto, BusinessProfilePicReadDto>();
            CreateMap<BusinessProfilePicReadDto, BusinessProfilePicCreateDto>();
            CreateMap<BusinessProfilePicCreateDto, BusinessProfilePicEntity>();
            CreateMap<BusinessProfilePicEntity, BusinessProfilePicCreateDto>();
            CreateMap<BusinessProfilePicReadDto, BusinessProfilePicEntity>();
            CreateMap<BusinessProfilePicEntity, BusinessProfilePicReadDto>();
            CreateMap<BusinessProfilePicCreateDto, BusinessProfilePic>();
            CreateMap<BusinessProfilePic, BusinessProfilePicCreateDto>();
            CreateMap<BusinessProfilePicReadDto, BusinessProfilePic>();
            CreateMap<BusinessProfilePic, BusinessProfilePicReadDto>();
            CreateMap<BusinessProfilePicEntity, BusinessProfilePic>();
            CreateMap<BusinessProfilePic, BusinessProfilePicEntity>();
            CreateMap<BusinessProfilePicUpdateDto, BusinessProfilePicEntity>();
            CreateMap<BusinessProfilePicEntity, BusinessProfilePicUpdateDto>();
            CreateMap<BusinessProfilePicUpdateDto, BusinessProfilePic>();
            CreateMap<BusinessProfilePic, BusinessProfilePicUpdateDto>();
            CreateMap<BusinessProfilePicUpdateDto, BusinessProfilePicCreateDto>();
            CreateMap<BusinessProfilePicCreateDto, BusinessProfilePicUpdateDto>();
            CreateMap<BusinessProfilePicUpdateDto, BusinessProfilePicReadDto>();
            CreateMap<BusinessProfilePicReadDto, BusinessProfilePicUpdateDto>();
        }
    }
}
