using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.UserServiceModels.AuthModels
{
    /// <summary>
    /// All instances or object implementing UserCategory must implement these properties
    /// </summary>
    #region Interfaces
    public interface IUserCategory
    {
        int AuthLevel { get; set; }

        string Description { get; set; }
        
    }
    #endregion

    public class UserCategoryModel : IUserCategory
    {
        #region Properties
        public int AuthLevel { get; set; }
        public string Description { get; set; }
        #endregion



    }
}
