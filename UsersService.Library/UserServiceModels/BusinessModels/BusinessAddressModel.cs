using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.UserServiceModels.BusinessModels
{
    public interface IBusinessAddress
    {
        string Unit { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Street { get; set; }
        string Zipcode { get; set; }
    }

    public class BusinessAddressModel : IBusinessAddress
    {
        #region Properties
        public string Street { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        #endregion
    }
}
