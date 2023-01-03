using FilmDukkani.Models.Entities.Abstract;
using System.Collections.Generic;

namespace FilmDukkani.Models.Entities.Concrete
{
    public class Membership  : BaseEntity
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int MovieChange { get; set; }
        public int MovieNumber { get; set; }
        public List<User> UserId { get; set; }
    }
}
