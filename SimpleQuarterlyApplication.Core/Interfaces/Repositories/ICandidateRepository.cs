using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Repositories
{
    public interface ICandidateRepository
    {
        Task<IEnumerable<Candidate>> Get();
        Task<Candidate> Create(Candidate candidate);
    }
}
