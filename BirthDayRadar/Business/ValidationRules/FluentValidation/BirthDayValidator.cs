using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BirthDayValidator : AbstractValidator<BirthDayRadar>
    {
        public BirthDayValidator()
        {
            RuleFor(p => p.Name).MinimumLength(1).Empty();
            RuleFor(p => p.Surname).MinimumLength(1).Empty();
            RuleFor(p => p.Telephone).MinimumLength(1).Empty();
            RuleFor(p => p.NewAge).Empty();
            RuleFor(p => p.Date).Empty();
            RuleFor(p => p.Job).MinimumLength(1).Empty();

        }
    }
}
