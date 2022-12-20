using HotChocolate.Types;

namespace SimpleQuarterlyApplication.Core.Entities
{
    [ObjectType(Name = "Candidate")]
    public class CandidateType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Resume { get; set; }

        public string[] Skills { get; set; }
    }
}
