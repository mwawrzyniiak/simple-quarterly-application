using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Services;

namespace SimpleQuarterlyApplication.GraphQL.API.Queries
{
    [ExtendObjectType("Query")]

    public class CandidateQuery
    {
        [GraphQLName("candidates")]
        [GraphQLDescription("Get all Candidates.")]
        public async Task<IEnumerable<Candidate>> GetCandidatesAsync([Service] ICandidateService candidateService) => await candidateService.Get();

    }
}
