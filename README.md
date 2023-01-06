# simple-quarterly-application  
## Table of contents
* [Getting Started](#getting-started)
* [Project Diagram](#project-diagram)
* [Solution Architecture](#solution-architecture)
* [Minimal API](#minimal-api)
* [GraphQL API](#graphql-api)
* [Dependencies](#dependencies)
* [Built With](#built-with)
* [Prerequsties](#prerequsties)
* [Deployment](#deployment)
* [Contributing](#contributing)
* [Authors](#authors)
* [License](#license)

## Getting Started  
This repository was created as a result of work on a quarterly project related to the development of backend development skills.  
The code contained in this repository was created for the purpose of learning individual .net elements.  
Additionally, the results of this work meet the requirements for the quarterly task carried out in 2022/2023.  

Quarterly target requirements:  
* Creating and presenting to the team a web application that utilizes some of the technologies included in the Backend Web Developer career path.  
* Including the use of ApplicationInsights.  

## Project Diagram  
![System Diagram](https://user-images.githubusercontent.com/35369071/210336315-ae1dd7c7-396d-410f-8c10-b6d3e4e27821.png)

## Solution Architecture
![Architecture](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/media/image5-7.png)
source: https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/media/image5-7.png  

## Minimal API  
### Candidates  
* **/candidates** - GET - get all candidates.  
* **/candidates/{id}** - GET - get candidate by id.
* **/candidates** - POST - create new candidate.  
* **/candidates/{id}** - PUT - update candidate by id.  
* **/candidates/{id}** - DELETE - delete candidate by id.  
### Companies  
* **/companies** - GET - get all companies.  
* **/companies/{id}** - GET - get company by id.
* **/companies** - POST - create new company.  
* **/companies/{id}** - PUT - update company by id.  
* **/companies/{id}** - DELETE - delete company by id.  
### Jobs  
* **/jobs** - GET - get all jobs. 
* **/jobs/{id}** - GET - get job by id. 
* **/jobs** - POST - create new job.  
* **/jobs/{id}** - PUT - update job by id.  
* **/jobs/{id}** - DELETE - delete job by id.  

## GraphQL API  
The GraphQL API for the job board or recruiting platform would allow users to interact with data related to job openings, candidates, and companies. Some possible types included in the schema are:
  
* Job: This type could include fields such as title, description, location, and salary.  
* Candidate: This type could include fields such as name, email, resume, and skills.  
* Company: This type could include fields such as name, industry, website, and description.  
  
Queries and mutations could be defined to allow users to perform actions such as:    
* Searching for jobs by keyword or location
* Applying to a job as a candidate  
* Creating/Updating/Viewing jobs.  
* Creating/Updating/Viewing candidate profile
* Creating/Updating/Viewing company profiles  

### Query
* **candidates** - get all candidates.  
* **companies** - get all companies.  
* **jobs** - get all jobs.  
* **jobsByKeyword** - get all jobs that contain keyword.  
* **jobsByLocation** - get all jobs by location.  

### Mutation
* **createCandidate** - creating candidate profile.  
* **updateCandidateById** -> updating candidate profile by id. 
* **createCompany** - creating company.  
* **updateCompanyById** - updateing company by id.  
* **createJob** - creating new job's ad.  
* **updateJob** - updating job's ad  

## Dependencies

simple-quarterly-application repository depends on a few packages:  
* [Microsoft.EntityFrameworkcore.Cosmos](https://learn.microsoft.com/pl-pl/ef/core/providers/cosmos/?tabs=dotnet-core-cli)  
* [HotChocolate.AspNetCore](https://chillicream.com/docs/hotchocolate/v12/get-started)  
* [Microsoft Application Insights](https://learn.microsoft.com/pl-pl/azure/azure-monitor/app/asp-net-core?tabs=netcorenew%2Cnetcore6)  
* [Microsoft Application Insights pt2](https://learn.microsoft.com/en-us/azure/azure-monitor/app/performance-counters?tabs=net-core-new)

## Built With

* [Visual Studio](https://visualstudio.microsoft.com/pl/vs/) - Idea

## Prerequsties  

What things you need to install the software and how to install them  

```
git clone https://github.com/mwawrzyniiak/simple-quarterly-application.git
```
  
* [CosmosDB Emulator](https://learn.microsoft.com/en-us/azure/cosmos-db/local-emulator?tabs=ssl-netstd21) - for work with CosmosDB

## Deployment  
Git clone, rebuild and run! :) 

## Contributing

Just send pull request and we'll see what to do with it.

## Authors

* **Maciej Wawrzyniak** 

## License

TODO
