using SimpleQuarterlyApplication.Core.Entities;
using SimpleQuarterlyApplication.Core.Interfaces.Repositories;
using SimpleQuarterlyApplication.Core.Interfaces.Services;
using SimpleQuarterlyApplication.Core.Services;
using SimpleQuarterlyApplication.Infrastructure;
using SimpleQuarterlyApplication.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SimpleQuarterlyApplicationContext>();

builder.Services.AddScoped<ICandidateService, CandidateService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IJobService, JobService>();

builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IJobRepository, JobRepository>();

var app = builder.Build();

app.MapGet("/candidates", async (ICandidateService candidateService) => await candidateService.Get());
app.MapPost("/candidates", async (ICandidateService candidateService, CandidateType candidate) =>
{
    await candidateService.Create(candidate);
    return Results.Created($"/candidates/{candidate.Id}", candidate);
});

app.MapGet("/companies", async (ICompanyService companyService) => await companyService.Get());
app.MapPost("/companies", async (ICompanyService companyService, CompanyType company) =>
{
    await companyService.Create(company);
    return Results.Created($"/companies/{company.Id}", company);
});

app.MapGet("/jobs", async (IJobService jobService) => await jobService.Get());
app.MapPost("/jobs", async (IJobService jobService, JobType job) =>
{
    await jobService.Create(job);
    return Results.Created($"/jobs/{job.Id}", job);
});

app.Run();
