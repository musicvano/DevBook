using Microsoft.EntityFrameworkCore;

namespace DevBook.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Lab> Labs { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
    }
}
