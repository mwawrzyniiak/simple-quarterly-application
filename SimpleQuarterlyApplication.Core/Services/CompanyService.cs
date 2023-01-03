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

        public async Task<IEnumerable<Company>> Get() => await _companyRepository.Get();
        public async Task<Company> Get(string id) => await _companyRepository.Get(id);
        public async Task<Company> Create(Company company) => await _companyRepository.Create(company);
        public async Task<bool> Update(Company company, string id) => await _companyRepository.Update(company, id);
        public async Task<bool> Delete(string id) => await _companyRepository.Delete(id);
    }
}
