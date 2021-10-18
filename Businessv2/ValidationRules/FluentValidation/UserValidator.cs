using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserValidator()
        {
            //RuleFor(u => u.uPassword).NotEmpty();
            //RuleFor(u => u.uPassword).MinimumLength(8);
            RuleFor(u => u.uMail).EmailAddress().WithMessage("Email adresi geçerli değil.") ;
            // RuleFor(u => u.uPassword).Must(SpecialChar);
            RuleFor(u => u.uName).MinimumLength(3).WithMessage("İsminiz minimum 3 harften oluşmalı.");
        }

        //private bool SpecialChar(string arg)
        //{
        //    return Contains(SpecialChar);
        //}
    }
}
