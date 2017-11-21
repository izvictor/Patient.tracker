using System.ComponentModel.DataAnnotations.Schema;

namespace Patient.Tracker.Model
{
    [Table("PatientAddress")]
    public class PatientAddress
    {
        public int PatientId { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual Patient Patient { get; set; }
    }
}