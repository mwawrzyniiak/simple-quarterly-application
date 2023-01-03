using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> Get();
        Task<Company> Get(string id);
        Task<Company> Create(Company company);
        Task<bool> Update(Company company, string id);
        Task<bool> Delete(string id);
    }
}
