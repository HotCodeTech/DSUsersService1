using System;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Data.Interfaces;
using UsersService.Data.Repositories;
using UsersService.Library.DataInterfaces;

namespace UsersService.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields
        private readonly UserDbContext _dbContext;
        private IGenericRepository<AddressEntity> addressRepository;
        private IGenericRepository<AuthorizationLevelEntity> authorizationLevelRepository;        
        private IGenericRepository<BusinessAddressEntity> businessAddressRepository;
        private IGenericRepository<BusinessEntity> businessRepository;
        private IGenericRepository<BusinessProfileEntity> businessProfileRepository;
        private IGenericRepository<BusinessProfilePicEntity> businessProfilePicRepository;
        private IGenericRepository<PermissionEntity> permissionRepository;
        private IGenericRepository<ProfilePicEntity> profilePicRepository;
        private IGenericRepository<ProfileEntity> profileRepository;
        private IGenericRepository<UserCategoryEntity> userCategoryRepository;
        private IGenericRepository<UserEntity> userRepository;

        #endregion

        #region Properties

        public IGenericRepository<AddressEntity> AddressRepository 
        {
            get 
            {
                if (addressRepository == null)
                {
                    addressRepository = new GenericRepository<AddressEntity>(_dbContext);
                }

                return addressRepository;
            }
        } 

        public IGenericRepository<AuthorizationLevelEntity> AuthorizationLevelRepository 
        {
            get
            {
                if (authorizationLevelRepository == null)
                {
                    authorizationLevelRepository = new GenericRepository<AuthorizationLevelEntity>(_dbContext);
                }

                return authorizationLevelRepository;
            }
        }

        public IGenericRepository<BusinessAddressEntity> BusinessAddressRepository
        {
            get
            {
                if (businessAddressRepository == null)
                {
                    businessAddressRepository = new GenericRepository<BusinessAddressEntity>(_dbContext);
                }

                return businessAddressRepository;
            }
        }

        public IGenericRepository<BusinessEntity> BusinessRepository 
        {
            get
            {
                if (businessRepository == null)
                {
                    businessRepository = new GenericRepository<BusinessEntity>(_dbContext);
                }

                return businessRepository;
            }
        }

        public IGenericRepository<BusinessProfileEntity> BusinessProfileRepository
        {
            get
            {
                if (businessProfileRepository == null)
                {
                    businessProfileRepository = new GenericRepository<BusinessProfileEntity>(_dbContext);
                }

                return businessProfileRepository;
            }
        }

        public IGenericRepository<BusinessProfilePicEntity> BusinessProfilePicRepository 
        {
            get
            {
                if (businessProfilePicRepository == null)
                {
                    businessProfilePicRepository = new GenericRepository<BusinessProfilePicEntity>(_dbContext);
                }

                return businessProfilePicRepository;
            }
        }

        public IGenericRepository<PermissionEntity> PermissionRepository 
        {
            get
            {
                if (permissionRepository == null)
                {
                    permissionRepository = new GenericRepository<PermissionEntity>(_dbContext);
                }

                return permissionRepository;
            }
        }

        public IGenericRepository<ProfilePicEntity> ProfilePicRepository 
        {
            get
            {
                if (profilePicRepository == null)
                {
                    profilePicRepository = new GenericRepository<ProfilePicEntity>(_dbContext);
                }

                return profilePicRepository;
            }
        }

        public IGenericRepository<ProfileEntity> ProfileRepository
        {
            get
            {
                if (profileRepository == null)
                {
                    profileRepository = new GenericRepository<ProfileEntity>(_dbContext);
                }

                return profileRepository;
            }
        }

        public IGenericRepository<UserCategoryEntity> UserCategoryRepository 
        {
            get
            {
                if (userCategoryRepository == null)
                {
                    userCategoryRepository = new GenericRepository<UserCategoryEntity>(_dbContext);
                }

                return userCategoryRepository;
            }
        }

        public IGenericRepository<UserEntity> UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new GenericRepository<UserEntity>(_dbContext);
                }

                return userRepository;
            }
        }

        #endregion

        #region Constructor
        public UnitOfWork(UserDbContext context)
        {
            _dbContext = context;
        }

        #endregion

        #region Methods
        public void Complete()
        {
           _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
