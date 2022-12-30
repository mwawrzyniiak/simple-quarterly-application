using HotChocolate.Types;

namespace SimpleQuarterlyApplication.Core.Entities
{
    [ObjectType(Name = "Candidate")]
    public class Candidate
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Resume { get; set; }

        public string[] Skills { get; set; }
    }
}
