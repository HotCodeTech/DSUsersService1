using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.UserServiceModels.UserModels
{
    /// <summary>
    /// All objects or instances representing an address must implement these properties
    /// </summary>
    #region Interfaces
    /// <summary>
    /// Any object representing an address must implement these properties and methods.
    /// </summary>
    public interface IAddress
    {
        string Apartment { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Street { get; set; }
        string Zipcode { get; set; }
    }
    #endregion

    /// <summary>
    /// Represents an object or instance of an address.
    /// </summary>
    public class AddressModel : IAddress
    {
        #region Properties
        public string Street { get; set; }
        public string Apartment { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        #endregion
    }
}
