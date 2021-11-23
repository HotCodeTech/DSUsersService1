using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Domain.Dtos;
using UsersService.Domain.Dtos.AuthorizationDtos;
using UsersService.Domain.Models;

namespace UsersService.Domain.MappingProfiles
{
    public class PermissionsProfile : Profile
    {
        public PermissionsProfile()
        {
            CreateMap<Permission, PermissionReadDto>();
            CreateMap<PermissionReadDto, Permission>();
            CreateMap<Permission, PermissionCreateDto>();
            CreateMap<PermissionCreateDto, Permission>();
            CreateMap<PermissionEntity, PermissionCreateDto>();
            CreateMap<PermissionCreateDto, PermissionEntity>();
            CreateMap<PermissionEntity, PermissionReadDto>();
            CreateMap<PermissionReadDto, PermissionEntity>();
            CreateMap<Permission, PermissionEntity>();
            CreateMap<PermissionEntity, Permission>();
            CreateMap<PermissionCreateDto, PermissionReadDto>();
            CreateMap<PermissionReadDto, PermissionCreateDto>();
            CreateMap<PermissionUpdateDto, PermissionCreateDto>();
            CreateMap<PermissionCreateDto, PermissionUpdateDto>();
            CreateMap<PermissionUpdateDto, PermissionReadDto>();
            CreateMap<PermissionReadDto, PermissionUpdateDto>();
            CreateMap<PermissionUpdateDto, Permission>();
            CreateMap<Permission, PermissionUpdateDto>();
            CreateMap<PermissionUpdateDto, PermissionEntity>();
            CreateMap<PermissionEntity, PermissionUpdateDto>();





        }
    }
}
