using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Library.UserServiceModels.AuthModels;
using UsersService.Library.UserServiceModels.ProfileModels;

namespace UsersService.Library.UserServiceModels.UserModels
{
    /// <summary>
    /// All instances or object implementing User must implement these properties.
    /// </summary>
    public interface IUser<T, T2>
    {
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }

#nullable enable
        T? Address { get; set; }
        T2? UserProfile { get; set; }
#nullable disable
        int UserCategory { get; set; }
    }

    /// <summary>
    /// An abstract class that any other object with these attributes and behavior extends.
    /// </summary>
    public class UserModel : IUser<AddressModel, ProfileModel>
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
#nullable enable
        public AddressModel? Address { get; set; }
        public ProfileModel? UserProfile { get; set; }
#nullable disable
        public int UserCategory { get; set; }
        #endregion

    }
}
