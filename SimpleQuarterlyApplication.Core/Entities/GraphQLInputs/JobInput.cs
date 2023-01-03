namespace SimpleQuarterlyApplication.Core.Entities.GraphQLInputs
{
    public class JobInput
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public decimal Salary { get; set; }
    }
}
