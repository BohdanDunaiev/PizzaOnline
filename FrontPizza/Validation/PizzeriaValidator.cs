using FrontPizza.ViewModels;
using FluentValidation;

namespace FrontPizza.Validation
{
    public class PizzeriaValidator : AbstractValidator<PizzeriaViewModel>
    {
        public PizzeriaValidator()
        {
            RuleFor(x => x.namePizzeria).MaximumLength(45);
            RuleFor(x => x.address).MaximumLength(45);          
        }
    }
}
