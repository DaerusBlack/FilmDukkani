using FilmDukkani.Models.Entities.Abstract;
using System;

namespace FilmDukkani.Models.Entities.Concrete
{
    public class CreditCard :  BaseEntity
    {

        public string CreditCardNumber { get; set; }
        public DateTime CardExpiryDate { get; set; }
        public int CvcCode { get; set; }
        public User UserId { get; set; }
    }
}
