using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.UserServiceModels.ProfileModels
{
    /// <summary>
    /// All instances or object implementing ProfilePic must implement these properties
    /// </summary>
    public interface IProfilePic
    {
        int Height { get; set; }
        string SourcePath { get; set; }
        int Width { get; set; }

    }

    /// <summary>
    /// The model blueprint for any object or instance of a ProfilePic
    /// </summary>
    public class ProfilePicModel : IProfilePic
    {
        #region Properties
        public int Width { get; set; }
        public int Height { get; set; }
        public string SourcePath { get; set; }

        #endregion
    }
}
