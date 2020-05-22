using FluentValidation;
using FrontPizza.ViewModels;

namespace FrontPizza.Validation
{
    public class PizzaValidator : AbstractValidator<PizzaViewModel>
    {
        public PizzaValidator()
        {
            RuleFor(c => c.namePizza)
                .NotEmpty().WithMessage("Name cann`t be empty")
                .MaximumLength(10).WithMessage("Name cannot be longer than 10 characters");

            RuleFor(c => c.size)
                .GreaterThanOrEqualTo(0).WithMessage("Size cann`t be empty");

            RuleFor(c => c.price)
                .GreaterThanOrEqualTo(0).WithMessage("Price cann`t be empty");
        }       
    }
}
