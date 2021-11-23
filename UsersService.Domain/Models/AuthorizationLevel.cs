using System.Collections.Generic;
using UsersService.Library.UserServiceModels.AuthModels;

namespace UsersService.Domain.Models
{
    public class AuthorizationLevel : IAuthorizationLevel<Permission>
    {
        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<Permission> Permissions { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor for object authorizationLevel. Instantiates all non primitive types witihn the class AuthorizationLevel.
        /// </summary>
        public AuthorizationLevel()
        {
            Permissions = new List<Permission>();
        }

        public AuthorizationLevel(List<Permission> permissions)
            :this()
        {
            Permissions = permissions;
        }
        #endregion

        #region Methods
        #endregion
    }
}