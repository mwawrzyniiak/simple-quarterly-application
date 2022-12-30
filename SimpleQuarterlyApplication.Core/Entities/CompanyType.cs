using HotChocolate.Types;

namespace SimpleQuarterlyApplication.Core.Entities
{
    [ObjectType(Name = "Company")]
    public class CompanyType
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public string? Industry { get; set; }

        public string? Website { get; set; }

        public string? Description { get; set; }
    }
}
