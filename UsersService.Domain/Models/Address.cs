using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Domain.Models
{
    public class Address : IAddress, IEntity
    {
        #region Properties
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Street { get; set; }
        public string Apartment { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor for object address. Instantiates all non primitive types witihn the class AddressModel.
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Takes all parameters to create an AddressModel object.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="apartment"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipcode"></param>
        public Address(string street, string apartment, string city, string state, string zipcode)
            : this()
        {
            Street = street;
            Apartment = apartment;
            City = city;
            State = state;
            Zipcode = zipcode;
        }
        #endregion

        #region Methods

        #endregion
    }
}
