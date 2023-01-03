using FilmDukkani.Models.Entities.Concrete;

using Microsoft.EntityFrameworkCore;

namespace FilmDukkani.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<FilmDukkani.Models.Entities.Concrete.Category> Category { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Movie> Movies { get; set; }
        //public DbSet<Membership> Memberships { get; set; }

    }
}
