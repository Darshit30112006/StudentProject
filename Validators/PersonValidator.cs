using FluentValidation;
using Problem1808.Models;

namespace Problem1808.Validators
{
    public class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator() {
            RuleFor(p => p.PersonName).NotEmpty().MaximumLength(11).WithMessage("The Person Name must be less than or Equal to  11 ");
            RuleFor(p => p.PersonCode).NotEmpty().Length(4);
            RuleFor(p=>p.EmailAddress).NotEmpty().EmailAddress();
            RuleFor(p => p.Age).NotEmpty().InclusiveBetween(1, 100);
            RuleFor(p=>p.Salary).NotEmpty().GreaterThan(10000);
            RuleFor(p => p.Department).NotEmpty();
        }
    }
}
    