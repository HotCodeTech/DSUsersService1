using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Domain.Dtos.ProfileDtos
{
    public class ProfilePicUpdateDto
    {
        [Required(ErrorMessage = "Profile Id is required for update.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Unique identifier of the entity owning this profile is required.")]
        public string Identifier { get; set; }

        public string SourcePath { get; set; }
    }
}
