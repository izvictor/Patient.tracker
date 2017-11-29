using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Patient.Tracker.Model
{
    [Table("Appointment")]
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public virtual IEnumerable<PatientAppointment> PatientAppointments { get; set; }


    }
}
