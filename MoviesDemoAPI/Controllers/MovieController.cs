using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesDemoAPI.DataContext;
using System.Text.Json;

namespace MoviesDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }


        [HttpGet("synopsis/{id}")]
        public async Task<IActionResult> GetMovieSynopsisById(int id)
        {
            var movieSynopsis = await _context.Movies
                                                .Where(movie => movie.Id == id)
                                                .Select(movie => movie.Synopsis)
                                                .FirstOrDefaultAsync();
            if (movieSynopsis == null)
            {
                return NotFound();
            }
            return Ok(movieSynopsis);
        }

    }
}
