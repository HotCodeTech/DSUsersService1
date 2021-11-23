using System.ComponentModel.DataAnnotations;

namespace UsersService.Domain.Dtos.BusinessDtos
{
    public class BusinessProfilePicUpdateDto
    {
        [Required(ErrorMessage = "The profile picture Id is required for update.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Unique identifier of the entity owning this profile picture is required.")]
        public string Identifier { get; set; }
        public string SourcePath { get; set; }
    }
}