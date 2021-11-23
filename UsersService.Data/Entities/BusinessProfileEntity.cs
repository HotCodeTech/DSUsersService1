using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.BusinessModels;
using UsersService.Library.UserServiceModels.ProfileModels;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Data.Entities
{
    [Index(nameof(Email), nameof(Password), nameof(BusinessProfileName), IsUnique = true)]
    public class BusinessProfileEntity : IBusinessProfile<BusinessProfilePicEntity>, IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DeleteDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string BusinessProfileName { get; set; }
        public BusinessProfilePicEntity ProfilePic { get; set; }
        // Naviagation Properties.
        [ForeignKey("Id")]
        public int BusinessId { get; set; }
        public BusinessEntity Business { get; set; }
        public string Identifier { get; set; }
    }
}