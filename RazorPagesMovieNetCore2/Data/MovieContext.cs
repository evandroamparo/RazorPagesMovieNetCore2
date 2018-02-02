using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovieNetCore2.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovieNetCore2.Models.Movie> Movie { get; set; }
    }
}
