using FrontPizza.ViewModels;
using FluentValidation;

namespace FrontPizza.Validation
{
    public class DeliveryViewModelValidator : AbstractValidator<DeliveryViewModel>
    {
        public DeliveryViewModelValidator()
        {
            RuleFor(x => x.nameDelivery).MaximumLength(45);
            RuleFor(x => x.time).MaximumLength(45);
            RuleFor(x => x.price).NotEmpty().GreaterThanOrEqualTo(0);
        }       
    }
}
