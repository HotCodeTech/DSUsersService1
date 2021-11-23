using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.GlobalInterfaces
{
    public interface IUserEntity
    {
        int UserCategory { get; set; }
    }
}
