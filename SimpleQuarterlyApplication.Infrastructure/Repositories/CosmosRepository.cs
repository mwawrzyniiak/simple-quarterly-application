namespace SimpleQuarterlyApplication.Infrastructure.Repositories
{
    public abstract class CosmosRepository
    {
        protected readonly SimpleQuarterlyApplicationContext _context;

        protected CosmosRepository(SimpleQuarterlyApplicationContext context)
        {
            _context = context;
        }   
    }
}
