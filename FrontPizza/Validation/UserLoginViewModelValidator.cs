using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FrontPizza.ViewModels;

namespace FrontPizza.Validation
{
    public class UserLoginViewModelValidator : AbstractValidator<UserLoginViewModel>
    {
        public UserLoginViewModelValidator()
        {
            RuleFor(x => x.userName)
                .NotEmpty();
            RuleFor(x => x.password)
                .NotEmpty();
        }
    }
}
