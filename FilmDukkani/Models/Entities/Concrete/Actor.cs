using FilmDukkani.Models.Entities.Abstract;
using System.Collections.Generic;

namespace FilmDukkani.Models.Entities.Concrete
{
    public class Actor : BaseEntity
    {
        public string Name { get; set; }
        public List<Movie> Movie { get; set; }
    }
}
