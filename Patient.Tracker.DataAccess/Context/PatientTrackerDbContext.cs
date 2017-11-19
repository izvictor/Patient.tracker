using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PatientModel = Patient.Tracker.Model.Patient;
namespace Patient.Tracker.DataAccess.Context
{
    public class PatientTrackerDbContext : IdentityDbContext<PatientModel, IdentityRole<int>, int>
    {
        public PatientTrackerDbContext(DbContextOptions<PatientTrackerDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Patient.Tracker;Trusted_Connection=True;");
        }
    }
}