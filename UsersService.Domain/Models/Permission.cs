using System.Collections.Generic;
using UsersService.Library.UserServiceModels.AuthModels;

namespace UsersService.Domain.Models
{
    public class Permission : IPermission<AuthorizationLevel>
    {
        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<AuthorizationLevel> AuthLevels { get; set; }
        #endregion

        #region Constructors
        public Permission()
        {
            AuthLevels = new List<AuthorizationLevel>();
        }

        public Permission(List<AuthorizationLevel> authLevels)
            :this()
        {
            AuthLevels = authLevels;
        }
        #endregion

    }
}