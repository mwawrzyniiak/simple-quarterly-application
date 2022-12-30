using Microsoft.EntityFrameworkCore;
using SimpleQuarterlyApplication.Core.Entities;

using static SimpleQuarterlyApplication.Infrastructure.Config;

namespace SimpleQuarterlyApplication.Infrastructure
{
    public class SimpleQuarterlyApplicationContext : DbContext
    {
        public DbSet<CandidateType> Candidates { get; set; }
        public DbSet<CompanyType> Companies { get; set; }
        public DbSet<JobType> Jobs { get; set; }

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
            modelBuilder.Entity<CandidateType>()
                .ToContainer("Candidates")
                .HasPartitionKey(e => e.Id);

            modelBuilder.Entity<CompanyType>()
                .ToContainer("Companies")
                .HasPartitionKey(e => e.Id);

            modelBuilder.Entity<JobType>()
                .ToContainer("Jobs")
                .HasPartitionKey(e => e.Id);
        }
    }
}
