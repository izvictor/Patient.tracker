using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Patient.Tracker.DataAccess.Context
{
    public class PatientTrackerDbContextFactory : IDesignTimeDbContextFactory<PatientTrackerDbContext>
    {
        /// <summary>
        /// Creates a new instance of a derived context.
        /// </summary>
        /// <param name="args">Arguments provided by the design-time service.</param>
        /// <returns>
        /// An instance of <typeparamref name="TContext" />.
        /// </returns>
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