using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Patient.Tracker.DataAccess.Context
{
    public class PatientTrackerDbContextFactory : IDesignTimeDbContextFactory<PatientTrackerDbContext>
    {
        PatientTrackerDbContext IDesignTimeDbContextFactory<PatientTrackerDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<PatientTrackerDbContext>();
            var connectionString = configuration.GetConnectionString("PatientTrackerConnection");
            builder.UseSqlServer(connectionString);
            return new PatientTrackerDbContext(builder.Options);
        }
    }
}