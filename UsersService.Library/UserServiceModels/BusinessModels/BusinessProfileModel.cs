using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.UserServiceModels.BusinessModels
{
    public interface IBusinessProfile<T>
    {
        string BusinessProfileName { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DeleteDate { get; set; }
        string Email { get; set; }
        string Password { get; set; }
#nullable enable
        T? ProfilePic { get; set; }
#nullable disable
    }

    public class BusinessProfileModel : IBusinessProfile<BusinessProfilePicModel>
    {
        public string BusinessProfileName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DeleteDate { get; set; }
#nullable enable
        public BusinessProfilePicModel? ProfilePic { get; set; }
#nullable disable
    }
}
