using FilmDukkani.Models.Entities.Abstract;
using System.Collections.Generic;

namespace FilmDukkani.Models.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public List<Movie>  Movie { get; set; }

    }
}
