using Microsoft.AspNetCore.Identity;
using System;

namespace Core.Entities
{
    public class Rater :  IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime  BirthDay { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
