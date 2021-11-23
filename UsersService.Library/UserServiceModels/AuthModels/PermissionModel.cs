using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.UserServiceModels.AuthModels
{
    public interface IPermission<T>
    {
        string Description { get; set; }

        IEnumerable<T> AuthLevels { get; set;  }
        
    }

    public class PermissionModel : IPermission<AuthorizationLevelModel>
    {
        public string Description { get; set; }
        public IEnumerable<AuthorizationLevelModel> AuthLevels { get; set; }
    }


}
