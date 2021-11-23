using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Data.Interfaces;

namespace UsersService.Data.Repositories
{
    public class UserRepository : GenericRepository<UserEntity>, IUserRepository
    {
        #region Fields

        #endregion

        #region Constructors
        public UserRepository(UserDbContext dbContext) : base(dbContext)
        {
        }
        #endregion

        #region Methods

        #endregion
    }
}
