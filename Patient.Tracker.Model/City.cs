using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Patient.Tracker.Model
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(32)]
        public string PostalCode { get; set; }

        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

    }
}