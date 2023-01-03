using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Services
{
    public interface ICandidateService
    {
        Task<IEnumerable<Candidate>> Get();
        Task<Candidate> Create(Candidate candidate);
        Task<bool> Update(Candidate candidate, string id);
        Task<bool> Delete(string id);

    }
}
