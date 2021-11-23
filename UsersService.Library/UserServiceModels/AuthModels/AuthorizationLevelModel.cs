using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.UserServiceModels.AuthModels
{
    /// <summary>
    /// All instances or objects representing an authorization level must implement these properties
    /// </summary>
    #region Interfaces
    public interface IAuthorizationLevel<T>
    {
        string Description { get; set; }
        IEnumerable<T> Permissions { get; set; }
    }
    #endregion
    public class AuthorizationLevelModel : IAuthorizationLevel<PermissionModel>
    {
        public string Description { get; set; }
        public IEnumerable<PermissionModel> Permissions { get; set; }
    }
}
