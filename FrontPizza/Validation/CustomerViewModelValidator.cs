using FrontPizza.ViewModels;
using FluentValidation;

namespace FrontPizza.Validation
{
    public class CustomerViewModelValidator : AbstractValidator<CustomerViewModel>
    {
        public CustomerViewModelValidator()
        {
            RuleFor(x => x.lastName).MaximumLength(45);
            RuleFor(x => x.firstName).MaximumLength(45);
            RuleFor(x => x.secondName).MaximumLength(45);
            RuleFor(x => x.adress).MaximumLength(45);
            RuleFor(x => x.phoneNumber).MaximumLength(45).Matches(@"^\+?3?8?(0\d{9})$");
        }
    }
}
