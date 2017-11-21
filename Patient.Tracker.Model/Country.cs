using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patient.Tracker.Model
{
    [Table("Country")]
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