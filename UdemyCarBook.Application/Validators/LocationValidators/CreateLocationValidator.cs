using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Command.LocationCommands;

namespace UdemyCarBook.Application.Validators.ReviewValidators
{
    public class CreateLocationValidator:AbstractValidator<CreateLocationCommand>
    {
        public CreateLocationValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(20);
            RuleFor(x => x.Name).NotEmpty().MinimumLength(10).WithMessage("xx");
        }
    }
}
