using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Entities.GraphQLInputs;
using SimpleQuarterlyApplication.Core.Interfaces.Services;
using SimpleQuarterlyApplication.GraphQL.API.Extensions;

namespace SimpleQuarterlyApplication.GraphQL.API.Mutations
{
    [ExtendObjectType("Mutation")]
    public class CandidateMutation
    {
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
    }
}
