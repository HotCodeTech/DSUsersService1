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
    public class BusinessProfilePic : IBusinessProfilePic, IEntity
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string SourcePath { get; set; }
    }
}
