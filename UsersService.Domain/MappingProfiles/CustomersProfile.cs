using AutoMapper;
using UsersService.Data.Entities;
using UsersService.Domain.Dtos;
using UsersService.Domain.Dtos.UserDtos.CustomerDtos;
using UsersService.Domain.Models;

namespace UsersService.Domain.MappingProfiles
{
    public class CustomersProfile : Profile
    {
        public CustomersProfile()
        {
            // Source -> Target
            CreateMap<CustomerCreateDto, User>();
            CreateMap<User, CustomerCreateDto>();
            CreateMap<User, CustomerReadDto>();
            CreateMap<CustomerReadDto, User>();
            CreateMap<UserEntity, CustomerReadDto>();
            CreateMap<CustomerReadDto, UserEntity>();
            CreateMap<UserEntity, CustomerCreateDto>();
            CreateMap<CustomerCreateDto, UserEntity>();
            CreateMap<UserEntity, User>();
            CreateMap<User, UserEntity>();
            CreateMap<CustomerCreateDto, CustomerReadDto>();
            CreateMap<CustomerReadDto, CustomerCreateDto>();
            CreateMap<CustomerUpdateDto, CustomerCreateDto>();
            CreateMap<CustomerCreateDto, CustomerUpdateDto>();
            CreateMap<CustomerUpdateDto, CustomerReadDto>();
            CreateMap<CustomerReadDto, CustomerUpdateDto>();
            CreateMap<CustomerUpdateDto, User>();
            CreateMap<User, CustomerUpdateDto>();
            CreateMap<CustomerUpdateDto, UserEntity>();
            CreateMap<UserEntity, CustomerUpdateDto>();
        }

    }
}
