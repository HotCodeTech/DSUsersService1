using UsersService.Data.Entities;
using UsersService.Data.Interfaces;

namespace UsersService.Data.Repositories
{
    public class UserCategoryRepository : GenericRepository<UserCategoryEntity>, IUserCategoryRepository
    {
        #region Fields

        #endregion

        #region Constructors

        public UserCategoryRepository(UserDbContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Methods

        #endregion
    }
}
