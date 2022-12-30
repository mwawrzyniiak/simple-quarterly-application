using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> Get();
        Task<Company> Create(Company company);
    }
}
