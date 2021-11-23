using System.Collections.Generic;

namespace UsersService.Domain.Dtos.AuthorizationDtos
{
    public class AuthorizationLevelReadDto
    {
        public int Id { get; set; }
        public IEnumerable<PermissionReadDto> Permissions { get; set; }
    }
}