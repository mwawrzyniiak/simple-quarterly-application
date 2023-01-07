using Microsoft.EntityFrameworkCore;
using SimpleQuarterlyApplication.Core.Entities;

using static SimpleQuarterlyApplication.Infrastructure.Config;

namespace SimpleQuarterlyApplication.Infrastructure
{
    public class SimpleQuarterlyApplicationContext : DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Job> Jobs { get; set; }

        public SimpleQuarterlyApplicationContext()
        {
            this.Database.EnsureCreated(); // not sure, is it should be here? :) 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos(URI, PRIMARY_KEY, DATABASE_NAME);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //in free azure account you can not use more than 400 ru :)...
            modelBuilder.Entity<Candidate>()
                .HasManualThroughput(1000)
                .ToContainer("Candidates")
                .HasPartitionKey(e => e.Id);

            //modelBuilder.Entity<Company>()
            //    .HasManualThroughput(1000)
            //    .ToContainer("Companies")
            //    .HasPartitionKey(e => e.Id);
            //
            //modelBuilder.Entity<Job>()
            //    .HasManualThroughput(1000)
            //    .ToContainer("Jobs")
            //    .HasPartitionKey(e => e.Id);
        }
    }
}
