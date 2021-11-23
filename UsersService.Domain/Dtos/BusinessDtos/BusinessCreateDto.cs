using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Domain.Dtos.BusinessDtos
{
    public class BusinessCreateDto
    {
        [Required(ErrorMessage = "Business name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A valid business address is required.")]
        public BusinessAddressCreateDto Address { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }
        public BusinessProfileCreateDto BusinessProfile { get; set; }
    }
}
