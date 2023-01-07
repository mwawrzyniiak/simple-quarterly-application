using FluentValidation;
using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Validations
{
    public class JobValidator :AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(x => x.Title).NotEmpty().NotNull();
            RuleFor(x => x.Salary).NotNull();
            RuleFor(x => x.Description).NotEmpty().NotNull().MinimumLength(10).MaximumLength(300);
            RuleFor(x => x.Location).NotEmpty().NotNull();
        }
    }
}
