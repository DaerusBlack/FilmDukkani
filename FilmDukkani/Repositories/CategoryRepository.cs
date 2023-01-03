using FilmDukkani.Infrastructure.Context;
using FilmDukkani.Models.Entities.Concrete;

namespace FilmDukkani.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(AppDbContext dbContext) : base (dbContext)
        {

        }
    }
}
