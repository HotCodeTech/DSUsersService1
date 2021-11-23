using System.ComponentModel.DataAnnotations;

namespace UsersService.Domain.Dtos.UserDtos
{
    public class AddressUpdateDto
    {
        [Required(ErrorMessage = "Address Id is required for update.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Unique identifier of the entity owning this address is required.")]
        public string Identifier { get; set; }

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