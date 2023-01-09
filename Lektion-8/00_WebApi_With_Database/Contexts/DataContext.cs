using _00_WebApi_With_Database.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _00_WebApi_With_Database.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<StatusEntity> Statuses { get; set; } = null!;
        public DbSet<CaseEntity> Cases { get; set; } = null!;
    }
}
