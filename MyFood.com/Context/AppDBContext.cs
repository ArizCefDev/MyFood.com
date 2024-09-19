using Microsoft.EntityFrameworkCore;
using MyFood.com.Entity;

namespace MyFood.com.Context
{
    public class AppDBContext:DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Social> Social { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {

        }
    }
}
