using FluentValidation;
using SimpleQuarterlyApplication.Core.Entities;

namespace SimpleQuarterlyApplication.Core.Validations
{
    public class CandidateValidator : AbstractValidator<Candidate>
    {
        public CandidateValidator()
        {
            RuleFor(x => x.Email).EmailAddress().NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Skills).NotEmpty();
        }
    }
}
