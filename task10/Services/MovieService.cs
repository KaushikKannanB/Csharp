using Microsoft.EntityFrameworkCore;
using task10.Data;
using task10.Models;

namespace task10.Services
{
    public class MovieService : IMovieService
    {
        private readonly Movie_db_context context;
        public MovieService(Movie_db_context context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await context.Movies.ToListAsync();
        }

        public async Task <Movie?> GetById(int id)
        {
            return await context.Movies.FindAsync(id);
        }

        public async Task <Movie> Create(Movie movie)
        {
            context.Movies.Add(movie);
            await context.SaveChangesAsync();
            return movie;
        }
        public async Task Update(Movie movie)
        {
            context.Movies.Update(movie);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var movie = await context.Movies.FindAsync(id);
            if(movie!=null)
            {
                context.Movies.Remove(movie);
                await context.SaveChangesAsync();
            }
        }
    }
}