using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Repositories
{
    public interface ICandidateRepository
    {
        Task<IEnumerable<Candidate>> Get();
        Task<Candidate> Create(Candidate candidate);
        Task<bool> Update(Candidate candidate, string id);
        Task<bool> Delete(string id);
    }
}
