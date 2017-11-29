using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Patient.Tracker.Model;
using PatientModel = Patient.Tracker.Model.Patient;

namespace Patient.Tracker.DataAccess.Context
{
    public class PatientTrackerDbContext : IdentityDbContext<PatientModel, IdentityRole<int>, int>
    {
        public PatientTrackerDbContext(DbContextOptions<PatientTrackerDbContext> options) : base(options)
        {
        }

        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PatientAppointment>()
                .HasKey(x => new { x.PatientId, x.AppointmentId });

            modelBuilder.Entity<PatientAddress>()
                .HasKey(x => new { x.PatientId, x.AddressId });

            modelBuilder.Entity<PatientAddress>()
                .HasOne(pt => pt.Patient)
                .WithMany(p => p.PatientAddresses)
                .HasForeignKey(pt => pt.PatientId);

            modelBuilder.Entity<PatientAddress>()
                .HasOne(pt => pt.Address)
                .WithMany(t => t.PatientAddresses)
                .HasForeignKey(pt => pt.AddressId);

            modelBuilder.Entity<PatientAppointment>()
                .HasOne(pt => pt.Patient)
                .WithMany(p => p.PatientAppointments)
                .HasForeignKey(pt => pt.PatientId);

            modelBuilder.Entity<PatientAppointment>()
                .HasOne(pt => pt.Appointment)
                .WithMany(t => t.PatientAppointments)
                .HasForeignKey(pt => pt.AppointmentId);
        }
    }
}