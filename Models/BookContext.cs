using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.SQLite.Models
{
    public class BookContext : DbContext {

        public DbSet<Book> Books { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blogging.db");
        }

    }
}