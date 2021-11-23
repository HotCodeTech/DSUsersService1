using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Library.DataInterfaces;

namespace UsersService.Data.Interfaces
{
    public interface IBusinessProfileRepository : IGenericRepository<BusinessProfileEntity>
    {
    }
}
