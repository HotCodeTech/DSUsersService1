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
    public class BusinessProfilesProfile : Profile
    {
        public BusinessProfilesProfile()
        {
            CreateMap<BusinessProfileCreateDto, BusinessProfile>();
            CreateMap<BusinessProfile, BusinessProfileCreateDto>();
            CreateMap<BusinessProfile, BusinessProfileReadDto>();
            CreateMap<BusinessProfileReadDto, BusinessProfile>();
            CreateMap<BusinessProfileEntity, BusinessProfileReadDto>();
            CreateMap<BusinessProfileReadDto, BusinessProfileEntity>();
            CreateMap<BusinessProfileEntity, BusinessProfileCreateDto>();
            CreateMap<BusinessProfileCreateDto, BusinessProfileEntity>();
            CreateMap<BusinessProfileEntity, BusinessProfile>();
            CreateMap<BusinessProfile, BusinessProfileEntity>();
            CreateMap<BusinessProfileCreateDto, BusinessProfileReadDto>();
            CreateMap<BusinessProfileReadDto, BusinessProfileCreateDto>();
            CreateMap<BusinessProfileUpdateDto, BusinessProfileCreateDto>();
            CreateMap<BusinessProfileCreateDto, BusinessProfileUpdateDto>();
            CreateMap<BusinessProfileUpdateDto, BusinessProfileReadDto>();
            CreateMap<BusinessProfileReadDto, BusinessProfileUpdateDto>();
            CreateMap<BusinessProfileUpdateDto, BusinessProfile>();
            CreateMap<BusinessProfile, BusinessProfileUpdateDto>();
            CreateMap<BusinessProfileUpdateDto, BusinessProfileEntity>();
            CreateMap<BusinessProfileEntity, BusinessProfileUpdateDto>();
        }
    }
}
