using MoviesProject.Service.Data;
using MoviesProject.Service.Models;

namespace MoviesProject.Service.Services
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        Movie? GetById(int id);
        List<Movie>? GetByName(string name);
        List<Movie>? GetByDescription(string description);
    }

    public class MovieService : IMovieService
    {
        private readonly ApplicationDBContext _dbContext;

        public MovieService(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public Movie? GetById(int id)
        {
            var result = _dbContext.Movies.Where(x => x.Id.Equals(id)).FirstOrDefault();
            return result;
        }

        public List<Movie>? GetByName(string name)
        {
            var result = _dbContext
                .Movies
                .Where(x => x.Title.Contains(name))
                .OrderByDescending(x => x.Year)
                .ToList();
            return result;
        }

        public List<Movie>? GetByDescription(string description)
        {
            var result = _dbContext
                .Movies
                .Where(x => x.Plot.Contains(description))
                .OrderByDescending(x => x.Year)
                .ToList();
            return result;
        }

        public List<Movie>? GetAll()
        {
            var result = _dbContext.Movies.OrderByDescending(x => x.Year).ToList();
            return result;
        }
    }
}