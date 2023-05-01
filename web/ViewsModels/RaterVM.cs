using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Util;

namespace Web.ViewsModels
{
    public class RaterVM
    {
        [Required]
         [MaxLength(10)]
         [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(2)]
        public string LastName { get; set; }
        public string AvatarUrl { get; set; }
        [Required]
        [DayOfBirth(MaxAge =60, MinAge =18)]
        public DateTime BirthDay { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [FileExtensions(Extensions =".jpg")]
        public IFormFile File { get; set; }
    }
}
