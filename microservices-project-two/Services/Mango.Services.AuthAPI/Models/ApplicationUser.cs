using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthAPI.Models
{
    /// <summary>
    /// Application User that extends <b>IdentityUser</b>
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        public required string Name { get; set; }
    }
}