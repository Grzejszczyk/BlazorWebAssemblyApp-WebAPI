using BlazorWebAssembly.Models;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Services
{
    public interface IMovieService
    {
        Task<Movie> GetMovie();
    }
}