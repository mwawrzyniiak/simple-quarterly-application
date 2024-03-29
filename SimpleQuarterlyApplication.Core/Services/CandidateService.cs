﻿using SimpleQuarterlyApplication.Core.Entities;
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

        public async Task<IEnumerable<Candidate>> Get() => await _candidateRepository.Get();
        public async Task<Candidate> Get(string id) => await _candidateRepository.Get(id);
        public async Task<Candidate> Create(Candidate candidate) => await _candidateRepository.Create(candidate);
        public async Task<bool> Update(Candidate candidate, string id) => await _candidateRepository.Update(candidate, id);
        public async Task<bool> Delete(string id) => await _candidateRepository.Delete(id);
    }
}
