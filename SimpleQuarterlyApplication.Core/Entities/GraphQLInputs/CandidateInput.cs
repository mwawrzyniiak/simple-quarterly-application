namespace SimpleQuarterlyApplication.Core.Entities.GraphQLInputs
{
    public class CandidateInput
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Resume { get; set; }
        public string[] Skills { get; set; }
    }
}
