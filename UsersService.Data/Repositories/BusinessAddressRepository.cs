using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Data.Interfaces;

namespace UsersService.Data.Repositories
{
    public class BusinessAddressRepository : GenericRepository<BusinessAddressEntity>, IBusinessAddressRepository
    {
        #region Fields

        #endregion

        #region Constructors
        public BusinessAddressRepository(UserDbContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Methods

        #endregion
    }
}
