﻿using HotChocolate.Types;

namespace SimpleQuarterlyApplication.Core.Entities
{
    [ObjectType(Name = "Job")]
    public class Job
    {
        public string? Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Location { get; set; }

        public decimal Salary { get; set; }
    }
}
