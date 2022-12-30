using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Repositories;
using SimpleQuarterlyApplication.Core.Interfaces.Services;

namespace SimpleQuarterlyApplication.Core.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<CompanyType> Create(CompanyType companyType) => await _companyRepository.Create(companyType);

        public async Task<IEnumerable<CompanyType>> Get() => await _companyRepository.Get();
    }
}
