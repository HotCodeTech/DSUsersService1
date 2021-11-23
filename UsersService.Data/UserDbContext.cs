using Microsoft.EntityFrameworkCore;
using UsersService.Data.Entities;

namespace UsersService.Data
{
    public class UserDbContext : DbContext
    {
        #region Properties
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<AuthorizationLevelEntity> AuthLevels { get; set; }
        public DbSet<BusinessAddressEntity> BusinessAddresses { get; set; }
        public DbSet<BusinessEntity> Businesses { get; set; }
        public DbSet<BusinessProfileEntity> BusinessProfiles { get; set; }
        public DbSet<BusinessProfilePicEntity> BusinessProfilePics { get; set; }
        public DbSet<PermissionEntity> Permissions { get; set; }
        public DbSet<ProfilePicEntity> ProfilePics { get; set; }
        public DbSet<ProfileEntity> Profiles { get; set; }
        public DbSet<UserCategoryEntity> UserCategories { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        #endregion

        #region Constructors
        public UserDbContext(DbContextOptions<UserDbContext> options)
           : base(options)
        {
        }
        #endregion
        #region Methods
      
        #endregion


    }
}
