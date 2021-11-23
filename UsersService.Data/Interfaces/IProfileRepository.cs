using UsersService.Data.Entities;
using UsersService.Library.DataInterfaces;

namespace UsersService.Data.Interfaces
{
    public interface IProfileRepository : IGenericRepository<ProfileEntity>
    {
    }
}
