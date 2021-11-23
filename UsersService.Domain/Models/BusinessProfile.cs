using System;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.BusinessModels;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Domain.Models
{
    public class BusinessProfile : IBusinessProfile<BusinessProfilePic>, IEntity
    {
        #region Properties
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string BusinessProfileName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DeleteDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
#nullable enable
        public BusinessProfilePic? ProfilePic { get; set; }
#nullable disable
        #endregion

        #region Constructors
        public BusinessProfile()
        {
            ProfilePic = new BusinessProfilePic();
        }
        public BusinessProfile(BusinessProfilePic profilePic)
            :this()
        {
            ProfilePic = profilePic;
        }
        #endregion

    }
}