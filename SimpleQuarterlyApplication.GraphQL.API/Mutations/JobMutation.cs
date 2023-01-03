using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Entities.GraphQLInputs;
using SimpleQuarterlyApplication.Core.Interfaces.Services;
using SimpleQuarterlyApplication.GraphQL.API.Extensions;

namespace SimpleQuarterlyApplication.GraphQL.API.Mutations
{
    [ExtendObjectType("Mutation")]
    public class JobMutation
    {
        [GraphQLName("createJob")]
        [GraphQLDescription("Add new job to the database.")]
        public async Task<Job> CreateJobAsync(JobInput jobInput, [Service] IJobService jobService)
        {
            var job = new Job()
            {
                Id = IdGenerator.GenerateId(),
                Salary = jobInput.Salary,
                Description = jobInput.Description,
                Location = jobInput.Location,
                Title = jobInput.Title
            };

            return await jobService.Create(job);
        }

        [GraphQLName("updateJobById")]
        [GraphQLDescription("Update job by id.")]
        public async Task<Job> UpdateJobAsync(string id, JobInput jobInput, [Service] IJobService jobService)
        {
            var job = await jobService.Get(id);
            if (job == null)
                throw new GraphQLException(new Error("Job not found.", "JOB_NOT_FOUND"));

            job.Id = IdGenerator.GenerateId();
            job.Salary = jobInput.Salary;
            job.Description = jobInput.Description;
            job.Location = jobInput.Location;
            job.Title = jobInput.Title;

            await jobService.Update(job, id);
            return job;
        }
    }
}
