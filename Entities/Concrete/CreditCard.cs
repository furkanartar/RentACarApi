using System;
using Core.Entities;

namespace Entities
{
    public class CreditCard : IEntity
    {
        public int Id { get; set; }
        public string CreditCardNumber { get; set; }
        public string Expiration { get; set; }
        public string CardSecurityNumber { get; set; }
    }
}