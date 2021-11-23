using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.UserServiceModels.ProfileModels
{
    /// <summary>
    /// All instances or object implementing Profile must implement these properties.
    /// </summary>
    #region Interfaces
    public interface IProfile<T>
    {
#nullable enable
        T? ProfilePic { get; set; }
#nullable disable
        DateTime DateCreated { get; set; }
        DateTime DeleteDate { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Username { get; set; }

    }
    #endregion
    /// <summary>
    /// An object or instance of a profile
    /// </summary>
    public class ProfileModel : IProfile<ProfilePicModel>
    {
        #region Properties
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DeleteDate { get; set; }
#nullable enable
        public ProfilePicModel? ProfilePic { get; set; }
#nullable disable
        #endregion
    }
}
