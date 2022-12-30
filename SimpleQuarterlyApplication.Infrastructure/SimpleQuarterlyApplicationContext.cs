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
            modelBuilder.Entity<Candidate>()
                .ToContainer("Candidates")
                .HasPartitionKey(e => e.Id);

            modelBuilder.Entity<Company>()
                .ToContainer("Companies")
                .HasPartitionKey(e => e.Id);

            modelBuilder.Entity<Job>()
                .ToContainer("Jobs")
                .HasPartitionKey(e => e.Id);
        }
    }
}
