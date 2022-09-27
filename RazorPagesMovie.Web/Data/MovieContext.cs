using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Web.Models;

namespace RazorPagesMovie.Web.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}