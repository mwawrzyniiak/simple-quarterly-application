using FluentValidation;
using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Validations
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Website).NotEmpty();
            RuleFor(x => x.Industry).NotEmpty();
            RuleFor(x => x.Description).NotEmpty().MinimumLength(10).MaximumLength(300);
        }
    }
}
