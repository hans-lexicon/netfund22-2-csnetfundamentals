using _02_WebApi_SpeedRun.Models;
using Microsoft.EntityFrameworkCore;

namespace _02_WebApi_SpeedRun
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
