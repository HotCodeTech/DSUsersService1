using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Domain.Dtos;
using UsersService.Domain.Dtos.BusinessDtos;
using UsersService.Domain.Models;

namespace UsersService.Domain.MappingProfiles
{
    public class BusinessesProfile : Profile
    {
        public BusinessesProfile()
        {
            CreateMap<Business, BusinessCreateDto>();
            CreateMap<BusinessCreateDto, Business>();
            CreateMap<Business, BusinessReadDto>();
            CreateMap<BusinessReadDto, Business>();
            CreateMap<BusinessEntity, BusinessReadDto>();
            CreateMap<BusinessReadDto, BusinessEntity>();
            CreateMap<BusinessCreateDto, BusinessEntity>();
            CreateMap<BusinessEntity, BusinessCreateDto>();
            CreateMap<Business, BusinessEntity>();
            CreateMap<BusinessEntity, Business>();
            CreateMap<BusinessCreateDto, BusinessReadDto>();
            CreateMap<BusinessReadDto, BusinessCreateDto>();
            CreateMap<BusinessUpdateDto, BusinessCreateDto>();
            CreateMap<BusinessCreateDto, BusinessUpdateDto>();
            CreateMap<BusinessUpdateDto, BusinessReadDto>();
            CreateMap<BusinessReadDto, BusinessUpdateDto>();
            CreateMap<BusinessUpdateDto, Business>();
            CreateMap<Business, BusinessUpdateDto>();
            CreateMap<BusinessUpdateDto, BusinessEntity>();
            CreateMap<BusinessEntity, BusinessUpdateDto>();




        }
    }
}
