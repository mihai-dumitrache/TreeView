using Microsoft.EntityFrameworkCore;

namespace TreeView.Models
{
    public class MyContext:DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public DbSet<Step> Steps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=. \\SQLEXPRESS;Initial Catalog=TreeView;Integrated Security=True");
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
