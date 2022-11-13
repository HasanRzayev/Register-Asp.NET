using FluentValidation;

namespace Login_Register.Models.Validators
{
    public class Validators:AbstractValidator<User>
    {
        public Validators()
        {
            RuleFor(s => s.email).NotEmpty().WithMessage("Email address is daxil et")
                     .EmailAddress().WithMessage("Duzgun daxil et");
            RuleFor(h => h.password).MaximumLength(8).WithMessage("8 den cox olmaz !!!!!");
        }
    }
}
