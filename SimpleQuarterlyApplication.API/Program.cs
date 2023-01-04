using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Repositories;
using SimpleQuarterlyApplication.Core.Interfaces.Services;
using SimpleQuarterlyApplication.Core.Services;
using SimpleQuarterlyApplication.Infrastructure;
using SimpleQuarterlyApplication.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationInsightsTelemetry();
builder.Services.AddDbContext<SimpleQuarterlyApplicationContext>();

builder.Services.AddScoped<ICandidateService, CandidateService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IJobService, JobService>();

builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IJobRepository, JobRepository>();

var app = builder.Build();

#region CANDIDATE CRUD

app.MapGet("/candidates", async (ICandidateService candidateService) => await candidateService.Get());
app.MapGet("/candidates/{id}", async (ICandidateService candidateService, string id) => await candidateService.Get(id));
app.MapPost("/candidates", async (ICandidateService candidateService, Candidate candidate) =>
{
    await candidateService.Create(candidate);
    return Results.Created($"/candidates/{candidate.Id}", candidate);
});
app.MapPut("/candidates/{id}", async (ICandidateService candidateService, Candidate candidate, string id) =>
{
    var result = await candidateService.Update(candidate, id);
    return result == true ? Results.Ok(candidate) : Results.Problem("Candidate update fail");
});
app.MapDelete("/candidates/{id}", async (ICandidateService candidateService, string id) =>
{
    var result = await candidateService.Delete(id);
    return result == true ? Results.Ok(id) : Results.Problem("Candidate delete fail");
});
    
#endregion

#region COMPANY CRUD

app.MapGet("/companies", async (ICompanyService companyService) => await companyService.Get());
app.MapGet("/companies/{id}", async (ICompanyService companyService, string id) => await companyService.Get(id));
app.MapPost("/companies", async (ICompanyService companyService, Company company) =>
{
    await companyService.Create(company);
    return Results.Created($"/companies/{company.Id}", company);
});
app.MapPut("/companies/{id}", async (ICompanyService companyService, Company company, string id) =>
{
    var result = await companyService.Update(company, id);
    return result == true ? Results.Ok(company) : Results.Problem("Company update fail");
});
app.MapDelete("/companies/{id}", async (ICompanyService companyService, string id) =>
{
    var result = await companyService.Delete(id);
    return result == true ? Results.Ok(id) : Results.Problem("Company delete fail");
});

#endregion

#region JOB CRUd

app.MapGet("/jobs", async (IJobService jobService) => await jobService.Get());
app.MapGet("/jobs/{id}", async (IJobService jobService, string id) => await jobService.Get(id));
app.MapPost("/jobs", async (IJobService jobService, Job job) =>
{
    await jobService.Create(job);
    return Results.Created($"/jobs/{job.Id}", job);
});
app.MapPut("/jobs/{id}", async (IJobService jobService, Job job, string id) =>
{
    var result = await jobService.Update(job, id);
    return result == true ? Results.Ok(job) : Results.Problem("Job update fail");
});
app.MapDelete("/companies/{id}", async (IJobService jobService, string id) =>
{
    var result = await jobService.Delete(id);
    return result == true ? Results.Ok(id) : Results.Problem("Job delete fail");
});

#endregion

app.Run();
