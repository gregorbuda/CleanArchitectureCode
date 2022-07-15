using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Directors.Commands.CreateDirector
{
    public class CreateCommandValidator : AbstractValidator<CreateDirectorCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotNull().WithMessage("Nombre no puede estar vacio");
            RuleFor(p => p.Apellido)
                .NotNull().WithMessage("Apellido no puede estar vacio");
        }
    }
}
