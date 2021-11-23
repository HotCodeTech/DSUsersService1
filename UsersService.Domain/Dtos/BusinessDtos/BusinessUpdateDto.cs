using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Domain.Dtos.BusinessDtos
{
    public class BusinessUpdateDto
    {
        [Required(ErrorMessage = "Id of business to update is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Unique identifier of this entity is required for update.")]
        public string Identifier { get; set; }

        [Required(ErrorMessage = "Business name is required.")]
        public string Name { get; set; }

        public BusinessAddressUpdateDto Address { get; set; }
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }

        public BusinessProfileUpdateDto BusinessProfile { get; set; }
    }
}
