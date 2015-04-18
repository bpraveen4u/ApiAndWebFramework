using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Sample.Fpp.Entities;
using Sample.Fpp.Resources;

namespace Sample.Fpp.Business.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(person => person.FirstName).NotEmpty().WithLocalizedMessage(() => Sample.Fpp.Resources.Main.FirstName_Required);//.WithLocalizedMessage(() => Main);
        }
    }
}
