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

        public async Task<IEnumerable<Company>> Get() => await _context.Companies.ToListAsync();

        public async Task<Company> Create(Company company)
        {
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
            return company;
        }

        public async Task<bool> Update(Company company, string id)
        {
            var elementToUpdate = _context.Companies.Where(x => x.Id == id).FirstOrDefault();

            if (elementToUpdate == null)
                return false;

            _context.Entry(elementToUpdate).State = EntityState.Detached;

            elementToUpdate = company;
            _context.Update(elementToUpdate);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(string id)
        {
            var elementToDelete = _context.Companies.Where(x => x.Id == id).FirstOrDefault();
            if (elementToDelete == null)
                return false;

            _context.Entry(elementToDelete).State = EntityState.Detached;

            _context.Companies.Remove(elementToDelete);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
