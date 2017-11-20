using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PatientModel = Patient.Tracker.Model.Patient;
namespace Patient.Tracker.DataAccess.Context
{
    public class PatientTrackerDbContext : IdentityDbContext<PatientModel, IdentityRole<int>, int>
    {
        public DbSet<PatientModel> Patients { get; set; }

        public PatientTrackerDbContext(DbContextOptions<PatientTrackerDbContext> options) : base(options)
        {

        }

    }
}