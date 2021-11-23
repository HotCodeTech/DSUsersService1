using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Library.GlobalInterfaces;

namespace UsersService.Domain.Dtos.AuthorizationDtos
{
    public class AuthorizationLevelUpdateDto
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public IEnumerable<PermissionReadDto> Permissions { get; set; }
    }
}
