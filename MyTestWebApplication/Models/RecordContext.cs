using Microsoft.EntityFrameworkCore;

namespace MyTestWebApplication.Models
{
    public class RecordContext : DbContext
    {
        public DbSet<Record> Records { get; set; } = null!;
        public RecordContext(DbContextOptions<RecordContext> options)
            : base(options)
        {
            Database.EnsureCreated();   
        }
    }
}
