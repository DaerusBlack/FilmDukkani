using FilmDukkani.Models.DTOs;
using FilmDukkani.Models.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FilmDukkani.Controllers
{
    
    public class AccountController : Controller
    {


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginDTO model)
        {
            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterDTO registerDTO)
        {
            User newUser = new User
            {
                Name = registerDTO.Name,
                LastName = registerDTO.LastName,
                Password = registerDTO.Password,
                MailAddress = registerDTO.MailAddress,
                Phone = registerDTO.Phone,
                Address = registerDTO.Address,
                //CardExpiryDate = registerDTO.CardExpiryDate,
                //CreditCardNumber = registerDTO.CreditCardNumber,
                //CvcCode = registerDTO.CvcCode,
                
            };
            return View(registerDTO);


        }
        
        
    }
}
