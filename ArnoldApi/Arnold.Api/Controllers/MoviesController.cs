using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arnold.Api.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(MoviesDataSource.Current.Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            var movieToReturn = MoviesDataSource.Current.Movies.FirstOrDefault(i => i.Id == id);

            if (movieToReturn == null)
            {
                return NotFound();
            }

            return Ok(movieToReturn);
        }
    }
}
