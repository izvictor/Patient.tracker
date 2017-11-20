using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Patient.Tracker.Model
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(3)]
        public string IsoCode { get; set; }
    }
}