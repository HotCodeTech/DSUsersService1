using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Library.DataInterfaces;

namespace UsersService.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<AddressEntity> AddressRepository { get;  }

        IGenericRepository<AuthorizationLevelEntity> AuthorizationLevelRepository { get; }

        IGenericRepository<BusinessAddressEntity> BusinessAddressRepository { get; }

        IGenericRepository<BusinessEntity> BusinessRepository { get; }

        IGenericRepository<BusinessProfileEntity> BusinessProfileRepository { get; }

        IGenericRepository<BusinessProfilePicEntity> BusinessProfilePicRepository { get; }

        IGenericRepository<PermissionEntity> PermissionRepository { get; }

        IGenericRepository<ProfilePicEntity> ProfilePicRepository { get; }

        IGenericRepository<ProfileEntity> ProfileRepository { get; }

        IGenericRepository<UserCategoryEntity> UserCategoryRepository { get; }

        IGenericRepository<UserEntity> UserRepository { get; }


        void Complete();
    }
}
