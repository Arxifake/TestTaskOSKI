using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using TestTaskOSKI.DataAccess.Models;

namespace TestTaskOSKI.DataAccess.DBContext
{
    public class TestAppContext:DbContext
    {
        public TestAppContext(DbContextOptions<TestAppContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TestUser>TestUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Test>()
                .HasMany(p => p.Users)
                .WithMany(p => p.Tests)
                .UsingEntity<TestUser>();
        }
    }
}
