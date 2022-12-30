using SimpleQuarterlyApplication.Core.Interfaces.Repositories;
using SimpleQuarterlyApplication.Core.Interfaces.Services;
using SimpleQuarterlyApplication.Core.Services;
using SimpleQuarterlyApplication.Infrastructure.Repositories;
using SimpleQuarterlyApplication.Infrastructure;
using SimpleQuarterlyApplication.GraphQL.API.Queries;
using SimpleQuarterlyApplication.GraphQL.API.Mutations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SimpleQuarterlyApplicationContext>();

builder.Services.AddScoped<ICandidateService, CandidateService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IJobService, JobService>();

builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IJobRepository, JobRepository>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType(q => q.Name("Query"))
    .AddType<CandidateQuery>()
    .AddMutationType(q => q.Name("Mutation"))
    .AddType<CandidateMutation>();

var app = builder.Build();

app.MapGraphQL("/graphql/v1");

app.Run();
