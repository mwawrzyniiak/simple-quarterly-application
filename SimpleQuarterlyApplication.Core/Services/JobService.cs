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

        public async Task<IEnumerable<Job>> Get() => await _jobRepository.Get();
        public async Task<Job> Get(string id) => await _jobRepository.Get(id);
        public async Task<Job> Create(Job job) => await _jobRepository.Create(job);
        public async Task<bool> Update(Job job, string id) => await _jobRepository.Update(job, id);
        public async Task<bool> Delete(string id) => await _jobRepository.Delete(id);
    }
}
