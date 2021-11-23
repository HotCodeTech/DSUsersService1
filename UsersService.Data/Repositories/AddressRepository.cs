using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Data.Interfaces;
using UsersService.Library.DataInterfaces;

namespace UsersService.Data.Repositories
{
    public class AddressRepository : GenericRepository<AddressEntity>, IAddressRepository
    {
        #region Fields

        #endregion

        #region Constructors

        public AddressRepository(UserDbContext dbContext) 
            : base(dbContext)
        {
        }
        #endregion

        #region Methods

        #endregion
    }
}
