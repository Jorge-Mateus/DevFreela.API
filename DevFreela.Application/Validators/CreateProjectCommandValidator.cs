using DevFreela.Application.Commands.CreateProject;
using FluentValidation;
using Microsoft.AspNetCore.Rewrite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(p => p.Description)
                .MaximumLength(255)
                .WithMessage("Tamanho máximo da Descrição é de 255 caracateres");

            RuleFor(p => p.Title)
                .MaximumLength(30)
                .WithMessage("O tamanho do título é de 30 caracteres");
        }
    }
}
