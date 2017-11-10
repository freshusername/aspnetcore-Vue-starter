using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Vue2Spa.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string GivenName { get; set; }
    }
}
