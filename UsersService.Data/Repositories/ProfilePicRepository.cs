using UsersService.Data.Entities;
using UsersService.Data.Interfaces;

namespace UsersService.Data.Repositories
{
    public class ProfilePicRepository : GenericRepository<ProfilePicEntity>, IProfilePicRepository
    {
        #region Fields

        #endregion

        #region Constructors

        public ProfilePicRepository(UserDbContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Methods

        #endregion
    }
}
