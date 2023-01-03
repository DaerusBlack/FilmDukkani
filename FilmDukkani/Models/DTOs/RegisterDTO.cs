using System;
using System.ComponentModel.DataAnnotations;

namespace FilmDukkani.Models.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]

        public string LastName { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]

        public string CreditCardNumber { get; set; }
        [Required]

        public DateTime CardExpiryDate { get; set; }
        [Required]

        public int CvcCode { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "You must type a valid email")]

        public string MailAddress { get; set; }
        [Required]

        public string Phone { get; set; }
        

        
    }
}
