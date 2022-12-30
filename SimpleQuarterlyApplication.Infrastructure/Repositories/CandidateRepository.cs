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

        public async Task<IEnumerable<CandidateType>> Get() => await _context.Candidates.ToListAsync();

        public async Task<CandidateType> Create(CandidateType candidateType)
        {
            await _context.Candidates.AddAsync(candidateType);
            await _context.SaveChangesAsync();
            return candidateType;
        }
    }
}
