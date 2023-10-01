using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Dto;
using MovieApp.Models;
using MovieApp.Services.Movies;

namespace MovieApp.Controllers
{
    [Route("movie")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;
        public MovieController (IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Movie>))]
        public IActionResult GetMovies()
        {
            var movies = _movieService.GetMovies();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(movies);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateMovie([FromBody] MovieDto createMovie)
        {
            if (createMovie == null)
            {
                return BadRequest(ModelState);
            }

            if (_movieService.MovieExsist(createMovie.Title))
            {
                ModelState.AddModelError("", "Movie already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var movieMap = _mapper.Map<Movie>(createMovie);

            if (!_movieService.CreateMovie(movieMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving movie");
                return StatusCode(500, ModelState);
            }

            return Ok("Movie added successfully");
        }
    }
}
