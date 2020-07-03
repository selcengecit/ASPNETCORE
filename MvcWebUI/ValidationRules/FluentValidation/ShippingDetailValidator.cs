using FluentValidation;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(expression: s => s.FirstName).NotEmpty().WithMessage("İsim zorunludur!");
            RuleFor(expression: s => s.FirstName).MinimumLength(2);
            RuleFor(expression: s => s.City).NotEmpty().When(s => s.Age<18);
           // RuleFor(expression: s => s.FirstName).Must(StartWithA); kural eklemeke istersen

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
