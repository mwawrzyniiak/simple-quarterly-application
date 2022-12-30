using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Repositories
{
    public interface ICandidateRepository
    {
        Task<IEnumerable<CandidateType>> Get();
        Task<CandidateType> Create(CandidateType candidateType);
    }
}
