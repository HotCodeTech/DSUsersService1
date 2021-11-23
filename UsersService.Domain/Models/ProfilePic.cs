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
    /// <summary>
    /// An object or instance of a ProfilePic
    /// </summary>
    public class ProfilePic : IProfilePic, IEntity
    {
        #region Properties
        public int Id { get; set; }
        public string Identifier { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string SourcePath { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// The main constructor of type profile. Instatiates all non primitive types in class UserProfile
        /// </summary>
        public ProfilePic()
        {

        }
        #endregion

        #region Methods
       
        #endregion
    }
}
