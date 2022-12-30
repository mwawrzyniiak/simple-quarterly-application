using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Services
{
    public interface IJobService
    {
        Task<IEnumerable<Job>> Get();
        Task<Job> Create(Job job);
    }
}
