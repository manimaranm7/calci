using Peakbyte.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Peakbyte.Data
{
    public class PeakbyteDbContext : DbContext
    {
        static PeakbyteDbContext()
        {
            Database.SetInitializer(new PeakbyteDatabaseInitializer());
        }

        public PeakbyteDbContext()
            : base(nameOrConnectionString: "Calculator") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Calculation> Calculations { get; set; }
        
    }
}
