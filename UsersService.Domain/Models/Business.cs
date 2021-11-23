using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.BusinessModels;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Domain.Models
{
    /// <summary>
    /// An object or instance of type BusinessModel
    /// </summary>
    public class Business : IBusiness<BusinessAddress, BusinessProfile>, IEntity
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public BusinessAddress Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public BusinessProfile BusinessProfile { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor for object appointment. Instantiates all non primitive types witihn the class Appointment.
        /// </summary>
        public Business()
        {
            Address = new BusinessAddress();
            BusinessProfile = new BusinessProfile();
            Identifier = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Takes all required prameters to create a business object.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="businessAddress"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="businessProfile"></param>
        public Business(string name, BusinessAddress businessAddress, string phoneNumber, BusinessProfile businessProfile)
            : this()
        {
            Name = name;
            Address = businessAddress;
            PhoneNumber = phoneNumber;
            BusinessProfile = businessProfile;
        }
        #endregion

        #region Methods


        #endregion
    }
}
