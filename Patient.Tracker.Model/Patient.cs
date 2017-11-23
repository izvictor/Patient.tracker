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

        [MaxLength(64)]
        public string Firstname { get; set; }

        [MaxLength(128)]
        public string Lastname { get; set; }

        public virtual IEnumerable<PatientAddress> PatientAddresses { get; set; }

    }
}