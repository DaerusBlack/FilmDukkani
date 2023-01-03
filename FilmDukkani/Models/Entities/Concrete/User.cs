using FilmDukkani.Models.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace FilmDukkani.Models.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
       
        public string MailAddress { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
       
        public List<CreditCard> CreditCards { get; set; }

        public Membership MembershipId { get; set; }

    }
}
