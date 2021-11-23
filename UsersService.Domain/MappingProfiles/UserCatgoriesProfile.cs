using AutoMapper;
using UsersService.Data.Entities;
using UsersService.Domain.Dtos;
using UsersService.Domain.Dtos.AuthorizationDtos;
using UsersService.Domain.Models;

namespace UsersService.Domain.MappingProfiles
{
    public class UserCatgoriesProfile : Profile
    {
        public UserCatgoriesProfile()
        {
            // Source -> Target
            CreateMap<UserCategoryCreateDto, UserCategory>();
            CreateMap<UserCategory, UserCategoryCreateDto>();
            CreateMap<UserCategoryReadDto, UserCategory>();
            CreateMap<UserCategory, UserCategoryReadDto>();
            CreateMap<UserCategoryCreateDto, UserCategoryEntity>();
            CreateMap<UserCategoryEntity, UserCategoryCreateDto>();
            CreateMap<UserCategoryReadDto, UserCategoryEntity>();
            CreateMap<UserCategoryEntity, UserCategoryReadDto>();
            CreateMap<UserCategory, UserCategoryEntity>();
            CreateMap<UserCategoryEntity, UserCategory>();
            CreateMap<UserCategoryCreateDto, UserCategoryReadDto>();
            CreateMap<UserCategoryReadDto, UserCategoryCreateDto>();
            CreateMap<UserCategoryUpdateDto, UserCategoryCreateDto>();
            CreateMap<UserCategoryCreateDto, UserCategoryUpdateDto>();
            CreateMap<UserCategoryUpdateDto, UserCategoryReadDto>();
            CreateMap<UserCategoryReadDto, UserCategoryUpdateDto>();
            CreateMap<UserCategoryUpdateDto, UserCategory>();
            CreateMap<UserCategory, UserCategoryUpdateDto>();
            CreateMap<UserCategoryUpdateDto, UserCategoryEntity>();
            CreateMap<UserCategoryEntity, UserCategoryUpdateDto>();




        }
    }
}
