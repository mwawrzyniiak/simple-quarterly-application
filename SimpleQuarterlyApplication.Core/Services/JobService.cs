using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Repositories;
using SimpleQuarterlyApplication.Core.Interfaces.Services;

namespace SimpleQuarterlyApplication.Core.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<JobType> Create(JobType jobType)
        {
            return await _jobRepository.Create(jobType);
        }

        public async Task<IEnumerable<JobType>> Get() => await _jobRepository.Get();
    }
}
