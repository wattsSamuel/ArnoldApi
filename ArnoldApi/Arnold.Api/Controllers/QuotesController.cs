using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Arnold.Api.Controllers
{
    [ApiController]
    [Route("api/movies/{movieId}/quotes")]
    public class QuotesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetQuotes(int movieId)
        {
            var movie = MoviesDataSource.Current.Movies.FirstOrDefault(i => i.Id == movieId);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie.Quotes);
        }

        [HttpGet("{id}", Name = "GetQuote")]
        public IActionResult GetQuote(int movieId, int id)
        {
            var movie = MoviesDataSource.Current.Movies.FirstOrDefault(i => i.Id == movieId);

            if(movie == null)
            {
                return NotFound();
            }

            var quote = movie.Quotes.FirstOrDefault(q => q.Id == id);

            if(quote == null)
            {
                return NotFound();
            }

            return Ok(quote);
        }
    }
}
