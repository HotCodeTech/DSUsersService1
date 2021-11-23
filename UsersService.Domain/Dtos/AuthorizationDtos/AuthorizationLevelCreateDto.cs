using System.Collections.Generic;

namespace UsersService.Domain.Dtos.AuthorizationDtos
{
    public class AuthorizationLevelCreateDto
    {
        public IEnumerable<PermissionUpdateDto> Permissions { get; set; }
    }
}