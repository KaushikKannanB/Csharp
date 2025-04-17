using Microsoft.EntityFrameworkCore;

using task10.Models;

namespace task10.Data
{
    public class Movie_db_context : DbContext
    {
        public Movie_db_context(DbContextOptions<Movie_db_context> options) : base(options) { }

        public DbSet<Movie> Movies {get; set;}
    }
}