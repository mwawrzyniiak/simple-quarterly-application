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

        public async Task<IEnumerable<Job>> Get() => await _context.Jobs.ToListAsync();

        public async Task<Job> Create(Job job)
        {
            await _context.Jobs.AddAsync(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task<bool> Update(Job job, string id)
        {
            var elementToUpdate = _context.Jobs.Where(x => x.Id == id).FirstOrDefault();

            if (elementToUpdate == null)
                return false;

            _context.Entry(elementToUpdate).State = EntityState.Detached;

            elementToUpdate = job;
            _context.Update(elementToUpdate);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(string id)
        {
            var elementToDelete = _context.Jobs.Where(x => x.Id == id).FirstOrDefault();
            if (elementToDelete == null)
                return false;

            _context.Entry(elementToDelete).State = EntityState.Detached;

            _context.Jobs.Remove(elementToDelete);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
