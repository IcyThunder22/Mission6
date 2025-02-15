using Microsoft.EntityFrameworkCore;
using Mission6;

namespace Mission6.Models // Ensure this namespace matches your project
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}
