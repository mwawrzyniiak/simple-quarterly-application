using Microsoft.EntityFrameworkCore;
using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Repositories;

namespace SimpleQuarterlyApplication.Infrastructure.Repositories
{
    public class JobRepository : CosmosRepository, IJobRepository
    {
        public JobRepository(SimpleQuarterlyApplicationContext context) : base(context)
        {
        }

        public async Task<IEnumerable<JobType>> Get() => await _context.Jobs.ToListAsync();

        public async Task<JobType> Create(JobType jobType)
        {
            await _context.Jobs.AddAsync(jobType);
            await _context.SaveChangesAsync();
            return jobType;
        }
    }
}
