using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.ProfileModels;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Domain.Models
{
    public class UserProfile : IProfile<ProfilePic>, IEntity
    {
        #region Properties
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DeleteDate { get; set; }
#nullable enable
        public ProfilePic? ProfilePic { get; set; }
#nullable disable
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor for object profile. Instantiates all non primitive types witihn the class UserProfile.
        /// </summary>
        public UserProfile()
        {
            ProfilePic = new ProfilePic();
        }

        public UserProfile(ProfilePic profilePic)
            :this()    
        {
            ProfilePic = profilePic;
        }

        #endregion 

        #region Methods
    
        #endregion
    }
}
