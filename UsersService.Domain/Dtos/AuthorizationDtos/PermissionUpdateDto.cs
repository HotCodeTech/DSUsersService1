using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Domain.Dtos.AuthorizationDtos
{
    public class PermissionUpdateDto
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }
    }
}
