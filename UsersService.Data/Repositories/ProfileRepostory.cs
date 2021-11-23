using UsersService.Data.Entities;
using UsersService.Data.Interfaces;

namespace UsersService.Data.Repositories
{
    public class ProfileRepostory : GenericRepository<ProfileEntity>, IProfileRepository
    {
        #region Fields

        #endregion

        #region Constructors

        public ProfileRepostory(UserDbContext dbContext) : base(dbContext)
        {
        }

        #endregion


        #region Methods

        #endregion
    }
}
