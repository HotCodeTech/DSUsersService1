using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Domain.Dtos;
using UsersService.Domain.Dtos.UserDtos;
using UsersService.Domain.Models;

namespace UsersService.Domain.MappingProfiles
{
    public class AddressesProfile : Profile
    {
        public AddressesProfile()
        {
            // Source -> Target
            CreateMap<AddressCreateDto, Address>();
            CreateMap<Address, AddressCreateDto>();
            CreateMap<Address, AddressReadDto>();
            CreateMap<AddressReadDto, Address>();
            CreateMap<AddressEntity, AddressReadDto>();
            CreateMap<AddressReadDto, AddressEntity>();
            CreateMap<AddressEntity, AddressCreateDto>();
            CreateMap<AddressCreateDto, AddressEntity>();
            CreateMap<AddressEntity, Address>();
            CreateMap<Address, AddressEntity>();
            CreateMap<AddressCreateDto, AddressReadDto>();
            CreateMap<AddressReadDto, AddressCreateDto>();
            CreateMap<AddressUpdateDto, Address>();
            CreateMap<Address, AddressUpdateDto>();
            CreateMap<AddressUpdateDto, AddressCreateDto>();
            CreateMap<AddressCreateDto, AddressUpdateDto>();
            CreateMap<AddressUpdateDto, AddressReadDto>();
            CreateMap<AddressReadDto, AddressUpdateDto>();
            CreateMap<AddressUpdateDto, AddressEntity>();
            CreateMap<AddressEntity, AddressUpdateDto>();

        }
    }
}
