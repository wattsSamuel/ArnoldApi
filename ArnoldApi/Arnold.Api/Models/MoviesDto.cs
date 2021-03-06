using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arnold.Api.Models
{
    public class MoviesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<QuotesDto> Quotes { get; set; } = new List<QuotesDto>();
    }
}
