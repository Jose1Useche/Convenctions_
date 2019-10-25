using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Convenctions.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}