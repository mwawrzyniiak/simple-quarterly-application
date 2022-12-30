using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Services
{
    public interface ICandidateService
    {
        Task<IEnumerable<CandidateType>> Get();
        Task<CandidateType> Create(CandidateType candidateType);
    }
}
