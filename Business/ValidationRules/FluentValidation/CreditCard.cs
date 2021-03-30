using System.Text.RegularExpressions;
using Entities;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CreditCard : AbstractValidator<Entities.CreditCard>
    {
        public CreditCard()
        {
            RuleFor(c => c.CreditCardNumber).NotEmpty();
            RuleFor(c => c.Expiration).NotEmpty();
            RuleFor(c => c.CardSecurityNumber).NotEmpty();

            RuleFor(c => c.CreditCardNumber).MinimumLength(16);
            RuleFor(c => c.CardSecurityNumber).MinimumLength(3);

            RuleFor(c => c.CreditCardNumber).Matches(new Regex(@"^[0-9]*$"));
            RuleFor(c => c.CardSecurityNumber).Matches(new Regex(@"^[0-9]*$"));
        }
    }
}