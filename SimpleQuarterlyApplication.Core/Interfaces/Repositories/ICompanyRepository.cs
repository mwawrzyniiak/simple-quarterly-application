using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<CompanyType>> Get();
        Task<CompanyType> Create(CompanyType companyType);
    }
}
