using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Services
{
    public interface IJobService
    {
        Task<IEnumerable<Job>> Get();
        Task<Job> Get(string id);
        Task<Job> Create(Job job);
        Task<bool> Update(Job job, string id);
        Task<bool> Delete(string id);
    }
}
