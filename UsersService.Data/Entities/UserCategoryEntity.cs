using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.AuthModels;

namespace UsersService.Data.Entities
{
    public class UserCategoryEntity : IUserCategory, IEntity
    {
        public int Id { get; set; }
        public int AuthLevel { get; set; }
        public string Identifier { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
