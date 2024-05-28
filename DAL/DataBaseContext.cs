using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class DataBaseContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<User> Users { get; set; }

    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
    }

    public DataBaseContext()
    {
        throw new NotImplementedException();
    }


    /**/
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=localdatabase.db");
    }
}
