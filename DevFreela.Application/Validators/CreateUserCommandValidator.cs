using DevFreela.Application.Commands.CreateUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(p => p.Email)
                .EmailAddress()
                .WithMessage("E-mail não é válido");

            RuleFor(p => p.Password)
                .Must(ValidPassword)
                .WithMessage("A senha deve coter pelo menos 8 caracteres, um número, uma letra maiúscula, uma minúscula, e um caracter especial");

            RuleFor(p => p.FullName)
                .NotEmpty()
                .NotNull()
                .WithMessage("O nome é obrigatório");
        }

        public bool ValidPassword(string password)
        {
            var regex = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");

            return regex.IsMatch(password);
        }
    }
}
