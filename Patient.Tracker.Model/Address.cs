using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patient.Tracker.Model
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        public string Street { get; set; }

        public virtual IEnumerable<PatientAddress> PatientAddresses { get; set; }

    }
}