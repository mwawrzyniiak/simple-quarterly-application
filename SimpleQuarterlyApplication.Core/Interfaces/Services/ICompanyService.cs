using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyType>> Get();
        Task<CompanyType> Create(CompanyType companyType);
    }
}
