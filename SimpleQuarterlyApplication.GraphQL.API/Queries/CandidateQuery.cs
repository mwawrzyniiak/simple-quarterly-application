using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Services;

namespace SimpleQuarterlyApplication.GraphQL.API.Queries
{
    [ExtendObjectType("Query")]
    public class CandidateQuery
    {
        [GraphQLName("jobs")]
        [GraphQLDescription("Get all jobs.")]
        public async Task<IEnumerable<Job>> GetJobsAsync([Service] IJobService jobService) => await jobService.Get();

        [GraphQLName("jobsByKeyword")]
        [GraphQLDescription("Get all jobs that contain keyword.")]
        public async Task<IEnumerable<Job>> GetJobsByKeyword([Service] IJobService jobService, string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
                return new Job[0];

            var jobs = await jobService.Get();

            if (jobs.Any())
                return jobs.Where(x => x.Description.Contains(keyword) || x.Title.Contains(keyword));

            return new Job[0]; //return empty, only for example :) 
        }

        [GraphQLName("jobsByLocation")]
        [GraphQLDescription("Get all jobs that location equal location from parameter.")]
        public async Task<IEnumerable<Job>> GetJobsByLocation([Service] IJobService jobService, string location)
        {
            if (string.IsNullOrEmpty(location))
                return new Job[0];

            var jobs = await jobService.Get();

            if (jobs.Any())
                return jobs.Where(x => x.Location.Contains(location));

            return new Job[0]; //return empty, only for example :) 
        }
    }
}
