using Microsoft.AspNetCore.Identity;

namespace PragimCore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}