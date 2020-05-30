using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FrontPizza.ViewModels;

namespace FrontPizza.Validation
{
    public class UserRegisterViewModelValidator : AbstractValidator<UserRegisterViewModel>
    {
        public UserRegisterViewModelValidator()
        {
            RuleFor(x => x.userName)
                .NotEmpty();

            RuleFor(x => x.email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.password)
                .NotEmpty()
                .MinimumLength(8);

            RuleFor(x => x.passwordConfirm)
                .NotEmpty()
                .Equal(x => x.password)
                .WithMessage("Passwords are not equal");
        }
    }
}
