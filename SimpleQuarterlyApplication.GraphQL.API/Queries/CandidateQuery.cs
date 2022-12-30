using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Services;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace SimpleQuarterlyApplication.GraphQL.API.Queries
{
    public class CandidateQuery
    {
        // Get All Jobs
        public async Task<IEnumerable<JobType>> GetJobsAsync([Service] IJobService jobService) => await jobService.Get();

        public async Task<IEnumerable<JobType>> GetJobsByKeyword([Service] IJobService jobService, string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
                return new JobType[0];

            var jobs = await jobService.Get();

            if (jobs.Any())
                return jobs.Where(x => x.Description.Contains(keyword) || x.Title.Contains(keyword));

            return new JobType[0]; //return empty, only for example :) 
        }

        public async Task<IEnumerable<JobType>> GetJobsByLocation([Service] IJobService jobService, string location)
        {
            if (string.IsNullOrEmpty(location))
                return new JobType[0];

            var jobs = await jobService.Get();

            if (jobs.Any())
                return jobs.Where(x => x.Location.Contains(location));

            return new JobType[0]; //return empty, only for example :) 
        }
    }
}
