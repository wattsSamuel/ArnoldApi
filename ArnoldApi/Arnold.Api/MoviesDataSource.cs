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
                    " tries to save his daughter, who was abducted by his former subordinate.",
                    Quotes = new List<QuotesDto>()
                    {
                        new QuotesDto()
                        {
                            Id = 1,
                            Quote = "Cooke: You scared, motherfucker? Well, you should be," +
                            " because this Green Beret is going to kick your big ass!" +
                            "John Matrix: I eat Green Berets for breakfast.And right now, I'm very hungry!"
                        },
                        new QuotesDto()
                        {
                            Id = 2,
                            Quote = "John Matrix: Let off some steam, Bennett."
                        }
                    }
                },
                new MoviesDto()
                {
                    Id = 2,
                    Name = "The Terminator",
                    Description = "The Terminator, a Cyberdyne Systems Model 101," +
                    " is an efficient killing machine with a powerful metal endoskeleton and an" +
                    " external layer of living tissue that disguises it as human.",
                    Quotes = new List<QuotesDto>()
                    {
                        new QuotesDto()
                        {
                            Id = 3,
                            Quote = "Kyle Reese: [to the Terminator] Come on, motherfucker!"
                        },
                        new QuotesDto()
                        {
                            Id = 4,
                            Quote = "Ginger Ventura: Machines need love too!"
                        }
                    }
                }
            };
        }
    }
}
