using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Models
{
    public class Movie
    {
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public bool Response { get; set; }
        public string Error { get; set; }
        public string UrlException { get; set; }
    }
}
