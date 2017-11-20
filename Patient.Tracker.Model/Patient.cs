using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Patient.Tracker.Model
{
    public class Patient : IdentityUser<int>
    {
        [Required]
        [MaxLength(64)]
        public string SocialSecurityNumber { get; set; }

        public virtual IEnumerable<PatientAddress> PatientAddresses { get; set; }

    }
}