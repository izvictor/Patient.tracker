using System.ComponentModel.DataAnnotations.Schema;

namespace Patient.Tracker.Model
{
    [Table("PatientAppointment")]
    public class PatientAppointment
    {
        public int PatientId { get; set; }
        public int AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
        public virtual Patient Patient { get; set; }
    }
}