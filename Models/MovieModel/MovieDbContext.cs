using System.Data.Entity;

namespace MVCMovie.Models.MovieModel
{
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}