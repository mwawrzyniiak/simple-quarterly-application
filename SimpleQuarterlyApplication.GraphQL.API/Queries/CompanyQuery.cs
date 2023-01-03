using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Services;

namespace SimpleQuarterlyApplication.GraphQL.API.Queries
{
    [ExtendObjectType("Query")]
    public class CompanyQuery
    {
        [GraphQLName("companies")]
        [GraphQLDescription("Get all Companies.")]
        public async Task<IEnumerable<Company>> GetCompanyAsync([Service] ICompanyService companyService) => await companyService.Get();
    }
}
