using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.ProfileModels;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Data.Entities
{
    [Index(nameof(Email), nameof(Password), nameof(Username), IsUnique = true)]
    public class ProfileEntity : IProfile<ProfilePicEntity>, IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Identifier { get; set; }
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
        public string Username { get; set; }
        public ProfilePicEntity ProfilePic { get; set; }

        // Naviagation Properties.
        [ForeignKey("Id")]
        public int UserId { get; set; }
        public UserEntity User { get; set; }
        
    }
}