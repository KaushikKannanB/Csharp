using task10.Models;

namespace task10.Services
{
    public interface IMovieService
    {
        Task <IEnumerable<Movie>> GetAll();
        Task <Movie?> GetById(int id);
        Task <Movie> Create(Movie movie);
        Task Update(Movie movie);
        Task Delete(int id);
    }
}