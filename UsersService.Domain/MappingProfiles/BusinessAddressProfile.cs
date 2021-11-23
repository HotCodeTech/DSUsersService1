using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Domain.Dtos.BusinessDtos;
using UsersService.Domain.Dtos.UserDtos;
using UsersService.Domain.Models;

namespace UsersService.Domain.MappingProfiles
{
    public class BusinessAddressProfile :Profile
    {
        public BusinessAddressProfile()
        {
            // Source -> Target
            CreateMap<BusinessAddressCreateDto, BusinessAddress>();
            CreateMap<BusinessAddress, BusinessAddressCreateDto>();
            CreateMap<BusinessAddress, BusinessAddressReadDto>();
            CreateMap<BusinessAddressReadDto, BusinessAddress>();
            CreateMap<BusinessAddressEntity, BusinessAddressReadDto>();
            CreateMap<BusinessAddressReadDto, BusinessAddressEntity>();
            CreateMap<BusinessAddressEntity, BusinessAddressCreateDto>();
            CreateMap<BusinessAddressCreateDto, BusinessAddressEntity>();
            CreateMap<BusinessAddressEntity, BusinessAddress>();
            CreateMap<BusinessAddress, BusinessAddressEntity>();
            CreateMap<BusinessAddressCreateDto, BusinessAddressReadDto>();
            CreateMap<BusinessAddressReadDto, BusinessAddressCreateDto>();
            CreateMap<BusinessAddressUpdateDto, BusinessAddress>();
            CreateMap<BusinessAddress, BusinessAddressUpdateDto>();
            CreateMap<BusinessAddressUpdateDto, BusinessAddressCreateDto>();
            CreateMap<BusinessAddressCreateDto, BusinessAddressUpdateDto>();
            CreateMap<BusinessAddressUpdateDto, BusinessAddressReadDto>();
            CreateMap<BusinessAddressReadDto, BusinessAddressUpdateDto>();
            CreateMap<BusinessAddressUpdateDto, BusinessAddressEntity>();
            CreateMap<BusinessAddressEntity, BusinessAddressUpdateDto>();
        }
    }
}
