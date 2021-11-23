using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Domain.Models;
using UsersService.Library.ServiceInterfaces;

namespace UsersService.Domain.Services.Interfaces
{
    public interface IMechanicService : IService<User>
    {
    }
}
