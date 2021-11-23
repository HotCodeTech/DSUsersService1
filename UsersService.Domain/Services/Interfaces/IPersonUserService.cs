using System.Collections.Generic;
using System.Threading.Tasks;
using UsersService.Domain.Dtos;
using UsersService.Domain.Models;
using UsersService.Library.ServiceInterfaces;

namespace UsersService.Domain.Services.Interfaces
{
    public interface IPersonUserService : IService<User>
    {
    }
}