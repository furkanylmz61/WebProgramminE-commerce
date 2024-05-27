using Entities;
using Microsoft.EntityFrameworkCore;

namespace WebProgrammingMVC.Data
{

    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> Users { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        /**/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=localdatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    IsActive = true,
                    Name = "Admin",
                    Password = "123456",
                    UserName = "Admin",
                    Email = "admin@NetCoreWebApplication.net",
                    Phone = "5522301655"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
