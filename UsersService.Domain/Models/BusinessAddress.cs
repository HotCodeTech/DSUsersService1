using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.BusinessModels;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Domain.Models
{
    public class BusinessAddress : IBusinessAddress, IEntity
    {
        #region Properties
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Street { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        #endregion

        #region Constructors
        public BusinessAddress()
        {

        }


        /// <summary>
        /// Takes all parameters to create a Business Address object.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="unit"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipcode"></param>
        public BusinessAddress(string street, string unit, string city, string state, string zipcode)
            :this()
        {
            Street = street;
            Unit = unit;
            City = city;
            State = state;
            Zipcode = zipcode;
        }
        #endregion

    }
}