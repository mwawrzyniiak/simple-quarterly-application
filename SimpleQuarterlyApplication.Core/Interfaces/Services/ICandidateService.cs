using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Services
{
    public interface ICandidateService
    {
        Task<IEnumerable<Candidate>> Get();
        Task<Candidate> Create(Candidate candidate);
    }
}
