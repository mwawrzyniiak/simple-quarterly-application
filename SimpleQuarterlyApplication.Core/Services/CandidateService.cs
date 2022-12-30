using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Repositories;
using SimpleQuarterlyApplication.Core.Interfaces.Services;

namespace SimpleQuarterlyApplication.Core.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public async Task<IEnumerable<CandidateType>> Get() => await _candidateRepository.Get();

        public async Task<CandidateType> Create(CandidateType candidateType) => await _candidateRepository.Create(candidateType);
    }
}
