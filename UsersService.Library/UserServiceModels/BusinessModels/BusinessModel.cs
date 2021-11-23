using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Library.UserServiceModels.BusinessModels
{
    /// <summary>
    /// All objects or instances representing a business must implement these properties
    /// </summary>
    public interface IBusiness<T, T2> : IEntity
    {
        string Name { get; set; }
        T Address { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        T2 BusinessProfile { get; set; }
    }

    /// <summary>
    /// An objec or instance of type BusinessModel
    /// </summary>
    public class BusinessModel : IBusiness<BusinessAddressModel, BusinessProfileModel>
    {
        #region Properties
        public string Name { get; set; }
        public string Identifier { get; set; }
        public BusinessAddressModel Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public BusinessProfileModel BusinessProfile { get; set; }

        #endregion
    }
}
