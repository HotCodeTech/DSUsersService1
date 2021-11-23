using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Library.UserServiceModels.AuthModels;

namespace UsersService.Domain.Models
{
    public class UserCategory : IUserCategory
    {
        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public int AuthLevel { get; set; }
        #endregion

        #region Constructors
        
        #endregion

        #region Methods

        #endregion
    }
}
