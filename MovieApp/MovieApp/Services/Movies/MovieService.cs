using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Services.Movies
{
    public class MovieService : IMovieService
    {
        private readonly DataContext _context;
        public MovieService(DataContext context)
        {
            _context = context;
        }
        public ICollection<Movie> GetMovies()
        {
            return _context.Movies.OrderBy(m => m.Episode_Id).ToList();
        }
    }
}
