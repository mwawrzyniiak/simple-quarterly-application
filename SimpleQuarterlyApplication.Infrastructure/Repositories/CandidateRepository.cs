using Microsoft.EntityFrameworkCore;
using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Repositories;

namespace SimpleQuarterlyApplication.Infrastructure.Repositories
{
    public class CandidateRepository : CosmosRepository, ICandidateRepository
    {
        public CandidateRepository(SimpleQuarterlyApplicationContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Candidate>> Get() => await _context.Candidates.ToListAsync();
        public async Task<Candidate> Get(string id) => await _context.Candidates.FirstOrDefaultAsync(x => x.Id.Equals(id));

        public async Task<Candidate> Create(Candidate candidate)
        {
            await _context.Candidates.AddAsync(candidate);
            await _context.SaveChangesAsync();
            return candidate;
        }

        public async Task<bool> Update(Candidate candidate, string id)
        {
            var elementToUpdate = _context.Candidates.Where(x => x.Id == id).FirstOrDefault();

            if (elementToUpdate == null)
                return false;

            _context.Entry(elementToUpdate).State = EntityState.Detached;

            elementToUpdate = candidate;
            _context.Update(elementToUpdate);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(string id)
        {
            var elementToDelete = _context.Candidates.Where(x => x.Id == id).FirstOrDefault();
            if (elementToDelete == null)
                return false;

            _context.Entry(elementToDelete).State = EntityState.Detached;

            _context.Candidates.Remove(elementToDelete);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
