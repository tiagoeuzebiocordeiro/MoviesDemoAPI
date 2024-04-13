using Microsoft.EntityFrameworkCore;
using MoviesDemoAPI.Entities;

namespace MoviesDemoAPI.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
       
        public DbSet<Movie> Movies { get; set; }

    }
}
