using FluentValidation;
using Project6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project6.Model.Validator
{
    public class AccountRegistrationValidator : AbstractValidator<AccountDto>
    {
        public AccountRegistrationValidator(PirateDBContext _context)
        {

            RuleFor(x => x.Login).MinimumLength(3)
                                 .MaximumLength(25)
                                 .Must(value => !_context.Account.Any(u => u.Login == value)).WithMessage("Login jest już używany");

            RuleFor(x => x.Password).MinimumLength(3)
                                    .MaximumLength(25);


        }
    }
}
