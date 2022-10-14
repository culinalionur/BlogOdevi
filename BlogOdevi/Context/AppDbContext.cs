using BlogOdevi.Models.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogOdevi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
