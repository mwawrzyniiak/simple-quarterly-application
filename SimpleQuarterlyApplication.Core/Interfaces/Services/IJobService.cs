using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Interfaces.Services
{
    public interface IJobService
    {
        Task<IEnumerable<JobType>> Get();
        Task<JobType> Create(JobType jobType);
    }
}
