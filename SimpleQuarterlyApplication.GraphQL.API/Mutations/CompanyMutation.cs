using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Entities.GraphQLInputs;
using SimpleQuarterlyApplication.Core.Interfaces.Services;
using SimpleQuarterlyApplication.GraphQL.API.Extensions;

namespace SimpleQuarterlyApplication.GraphQL.API.Mutations
{
    [ExtendObjectType("Mutation")]
    public class CompanyMutation
    {
        private readonly ILogger _logger;

        public CompanyMutation(ILogger<CompanyMutation> logger)
        {
            _logger = logger;
        }

        [GraphQLName("createCompany")]
        [GraphQLDescription("Add new company to the database.")]
        public async Task<Company> CreateCompanyAsync(CompanyInput companyInput, [Service] ICompanyService companyService)
        {
            var company = new Company()
            {
                Id = IdGenerator.GenerateId(),
                Name = companyInput.Name,
                Description = companyInput.Description,
                Industry = companyInput.Industry,
                Website = companyInput.Website
            };

            return await companyService.Create(company);
        }

        [GraphQLName("updateCompanyById")]
        [GraphQLDescription("Update company by id.")]
        public async Task<Company> UpdateCompanyAsync(string id, CompanyInput companyInput, [Service] ICompanyService companyService)
        {
            var company = await companyService.Get(id);
            if (company == null)
            {
                _logger.LogWarning("Company not found. Can't update company.");
                throw new GraphQLException(new Error("Company not found.", "COMPANY_NOT_FOUND"));
            }

            company.Name = companyInput.Name;
            company.Description = companyInput.Description;
            company.Industry = companyInput.Industry;
            company.Website = companyInput.Website;

            await companyService.Update(company, id);
            return company;
        }
    }
}
