using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.AuthModels;

namespace UsersService.Data.Entities
{
    public class PermissionEntity : IPermission<AuthorizationLevelEntity>, IEntity
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        // Naviation Propeties
        public IEnumerable<AuthorizationLevelEntity> AuthLevels { get; set; }
        public string Identifier { get; set; }
    }
}