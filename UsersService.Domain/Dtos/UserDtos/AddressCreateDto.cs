using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Domain.Dtos.UserDtos
{
    public class AddressCreateDto
    {
        [Required(ErrorMessage = "Street name is required")]
        public string Street { get; set; }
        public string Apartment { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        public string State { get; set; }

        [DataType(DataType.PostalCode, ErrorMessage = "Please enter a valid postal code.")]
        public string Zipcode { get; set; }

    }
}
