using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class TaskContext : DbContext
    {
        public DbSet<TodoTask> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public string DbPath { get; }

        public TaskContext()
        {
            DbPath = "bin/TodoTask.db"; // Stien til SQLite-databasen
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoTask>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId);
        }
    }
}
