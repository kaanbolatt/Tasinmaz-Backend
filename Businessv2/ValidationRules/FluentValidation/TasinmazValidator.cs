using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class TasinmazValidator : AbstractValidator<Tasinmaz>
    {
        public TasinmazValidator()
        {
            //RuleFor(u => u.uPassword).NotEmpty();
            //RuleFor(u => u.uPassword).MinimumLength(8);
           // RuleFor(u => u.uMail).EmailAddress();
           // RuleFor(u => u.uPassword).Must(SpecialChar);
        }

        //private bool SpecialChar(string arg)
        //{
        //    return Contains(SpecialChar);
        //}
    }
}
