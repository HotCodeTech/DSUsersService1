using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.AuthModels;

namespace UsersService.Data.Entities
{
    public class AuthorizationLevelEntity : IAuthorizationLevel<PermissionEntity>, IEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public IEnumerable<PermissionEntity> Permissions { get; set; }
        public string Identifier { get; set; }
    }
}