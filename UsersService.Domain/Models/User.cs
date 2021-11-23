using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Domain.Models
{
    public class User : IUser<Address, UserProfile>, IEntity, IUserEntity
    {
        #region Properties

        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
#nullable enable
        public Address? Address { get; set; }
        public UserProfile? UserProfile { get; set; }
#nullable disable
        public int UserCategory { get; set; }

        #endregion

        #region Constructors
        public User()
        {
            Address = new Address();
            UserProfile = new UserProfile();
            Identifier = Guid.NewGuid().ToString();
        }

        public User(string firstName, string lastName, string phoneNumber, string email, Address userAddress, UserProfile userProfile)
            :this()
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = userAddress;
            UserProfile = userProfile;
        }
        #endregion

    }
}
