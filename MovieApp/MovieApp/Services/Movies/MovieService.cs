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

        public bool CreateMovie(Movie movie)
        {
            _context.Add(movie);
            return Save();
        }

        public ICollection<Movie> GetMovies()
        {
            return _context.Movies.OrderBy(m => m.Episode_Id).ToList();
        }

        public bool MovieExsist(string title)
        {
            return _context.Movies.Any(m => m.Title == title);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
