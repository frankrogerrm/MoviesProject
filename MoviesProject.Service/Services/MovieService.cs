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
        List<Movie>? GetSearch(string generalPar);
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
                .Where(x => x.Title.ToLower().Contains(name.ToLower()))
                .OrderByDescending(x => x.Year)
                .ToList();
            return result;
        }

        public List<Movie>? GetByDescription(string description)
        {
            var result = _dbContext
                .Movies
                .Where(x => x.Plot.ToLower().Contains(description.ToLower()))
                .OrderByDescending(x => x.Year)
                .ToList();
            return result;
        }

        public List<Movie>? GetSearch(string generalPar)
        {
            var result = (
                from m in _dbContext.Movies
                where
                    m.Year.ToString().Contains(generalPar.ToString().ToLower())
                    || m.Title.ToLower().Contains(generalPar.ToLower())
                    || m.Plot.ToLower().Contains(generalPar.ToLower())
                select m
            )
                .Distinct()
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
