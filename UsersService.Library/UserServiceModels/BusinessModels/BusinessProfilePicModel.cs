using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.UserServiceModels.BusinessModels
{
    public interface IBusinessProfilePic
    {
        int Height { get; set; }
        string SourcePath { get; set; }
        int Width { get; set; }
    }

    public class BusinessProfilePicModel : IBusinessProfilePic
    {
        #region Properties
        public int Width { get; set; }
        public int Height { get; set; }
        public string SourcePath { get; set; }
        #endregion
    }
}
