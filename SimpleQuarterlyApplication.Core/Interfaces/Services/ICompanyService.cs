using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> Get();
        Task<Company> Create(Company company);
    }
}
