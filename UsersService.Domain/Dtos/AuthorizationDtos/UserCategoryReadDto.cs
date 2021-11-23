using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Domain.Dtos.AuthorizationDtos
{
    public class UserCategoryReadDto
    {
        public int Id { get; set; }
        public int AuthLevel { get; set; }
    }
}
