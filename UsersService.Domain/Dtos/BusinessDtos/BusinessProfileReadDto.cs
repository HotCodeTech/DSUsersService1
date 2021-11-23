using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Domain.Dtos.BusinessDtos
{
    public class BusinessProfileReadDto
    {
        public int Id { get; set; }
        public BusinessProfilePicReadDto ProfilePic { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string BusinessProfileName { get; set; }
    }
}
