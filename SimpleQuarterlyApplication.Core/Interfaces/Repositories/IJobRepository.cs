using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Repositories
{
    public interface IJobRepository
    {
        Task<IEnumerable<JobType>> Get();
        Task<JobType> Create(JobType jobType);
    }
}
