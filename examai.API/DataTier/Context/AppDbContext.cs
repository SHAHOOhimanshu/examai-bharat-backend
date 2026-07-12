//namespace examai.API.DataTier.Context
//{
//    public class AppDbContext
//    {
//    }
//}
using Microsoft.EntityFrameworkCore;
using examai.API.DataTier.EntityModels.Models;

namespace examai.API.DataTier.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}