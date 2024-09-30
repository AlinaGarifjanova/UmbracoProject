using UmbracoProject.Models;

namespace UmbracoProject.Business.Services
{
    public interface IMovieService
    {
        Task<List<MovieDetails>> GetMoviesWithDetailsAsync(string query);
    }
}
