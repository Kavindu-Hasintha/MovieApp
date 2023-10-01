using MovieApp.Models;

namespace MovieApp.Services.Movies
{
    public interface IMovieService
    {
        ICollection<Movie> GetMovies();
        bool CreateMovie(Movie movie);
        bool MovieExsist(string title);
        bool Save();
    }
}
