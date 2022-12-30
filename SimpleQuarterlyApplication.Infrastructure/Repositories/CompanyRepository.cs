using Microsoft.EntityFrameworkCore;
using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Repositories;

namespace SimpleQuarterlyApplication.Infrastructure.Repositories
{
    public class CompanyRepository : CosmosRepository, ICompanyRepository
    {
        public CompanyRepository(SimpleQuarterlyApplicationContext context) : base(context)
        {
        }

        public async Task<IEnumerable<CompanyType>> Get() => await _context.Companies.ToListAsync();

        public async Task<CompanyType> Create(CompanyType companyType)
        {
            await _context.Companies.AddAsync(companyType);
            await _context.SaveChangesAsync();
            return companyType;
        }
    }
}
