using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Repositories
{
    public interface IJobRepository
    {
        Task<IEnumerable<Job>> Get();
        Task<Job> Create(Job job);
    }
}
