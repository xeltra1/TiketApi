using Microsoft.EntityFrameworkCore;
using TiketApi.Models;

namespace TiketApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TiketModel> Tikets { get; set;}
    }
}
