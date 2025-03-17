using JWTAuthDotnet.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthDotnet.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
