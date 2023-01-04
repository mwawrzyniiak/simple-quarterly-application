using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Entities.GraphQLInputs;
using SimpleQuarterlyApplication.Core.Interfaces.Services;
using SimpleQuarterlyApplication.GraphQL.API.Extensions;

namespace SimpleQuarterlyApplication.GraphQL.API.Mutations
{
    [ExtendObjectType("Mutation")]
    public class CandidateMutation
    {
        private readonly ILogger _logger;

        public CandidateMutation(ILogger<CandidateMutation> logger)
        {
            _logger = logger;
        }

        [GraphQLName("createCandidate")]
        [GraphQLDescription("Add new candidate to the database.")]
        public async Task<Candidate> CreateCandidateAsync(CandidateInput candidateInput, [Service] ICandidateService candidateService)
        {
            var candidate = new Candidate()
            {
                Id = IdGenerator.GenerateId(),
                Name = candidateInput.Name,
                Skills = candidateInput.Skills,
                Email = candidateInput.Email,
                Resume = candidateInput.Resume
            };

            return await candidateService.Create(candidate);
        }

        [GraphQLName("updateCandidateById")]
        [GraphQLDescription("Update candidate by id.")]
        public async Task<Candidate> UpdateCandidateAsync(string id, CandidateInput candidateInput, [Service] ICandidateService candidateService)
        {
            var candidate = await candidateService.Get(id);
            if (candidate == null)
            {
                _logger.LogWarning("Candidate not found. Can't update candidate.");
                throw new GraphQLException(new Error("Candidate not found.", "CANDIDATE_NOT_FOUND"));
            }

            candidate.Name = candidateInput.Name;
            candidate.Skills = candidateInput.Skills;
            candidate.Email = candidateInput.Email;
            candidate.Resume = candidateInput.Resume;

            await candidateService.Update(candidate, id);
            return candidate;
        }
    }
}
