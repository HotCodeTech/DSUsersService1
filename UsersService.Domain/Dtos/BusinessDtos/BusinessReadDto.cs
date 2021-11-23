using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Domain.Dtos.BusinessDtos
{
    public class BusinessReadDto
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public BusinessAddressReadDto Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public BusinessProfileReadDto BusinessProfile { get; set; }
    }
}
