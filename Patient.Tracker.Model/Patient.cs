using Microsoft.AspNetCore.Identity;

namespace Patient.Tracker.Model
{
    public class Patient : IdentityUser<int>
    {
        public string SocialSecurityNumber { get; set; }

    }
}