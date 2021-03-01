using BlazorWebAssembly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _http;
        public MovieService(HttpClient http)
        {
            _http = http;
        }
        public async Task<Movie> GetMovie()
        {
            Movie movie;
            movie = await _http.GetFromJsonAsync<Movie>($"http://www.omdbapi.com/?t=Avatar&apikey=SecretCode&plot=full&type=movie");
            return movie;
        }
    }
}
