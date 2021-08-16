using Arnold.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arnold.Api
{
    public class MoviesDataSource
    {
        public static MoviesDataSource Current { get; } = new MoviesDataSource();

        public List<MoviesDto> Movies { get; set; }

        public MoviesDataSource()
        {
            Movies = new List<MoviesDto>()
            {
                new MoviesDto()
                {
                    Id = 1,
                    Name = "Commando",
                    Description = "A retired Special Forces colonel tries to save his daughter," +
                    " who was abducted by his former subordinate. A retired Special Forces colonel" +
                    " tries to save his daughter, who was abducted by his former subordinate."
                }
            };
        }
    }
}
