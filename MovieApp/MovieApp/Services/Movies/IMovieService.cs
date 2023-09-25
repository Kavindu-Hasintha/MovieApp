using MovieApp.Models;

namespace MovieApp.Services.Movies
{
    public interface IMovieService
    {
        ICollection<Movie> GetMovies();
    }
}
