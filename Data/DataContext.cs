using BookReview.Model;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace BookReview.Data
{
    public class DataContext : DbContext
    {
        public string DbPath { get; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //SQLitePCL.Batteries.Init();
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.CurrentDirectory;
            DbPath = System.IO.Path.Join(path, "Book.db");
            Console.WriteLine(path);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source = {DbPath}");
        public DbSet<Book> Books { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<RefreshToken> refreshTokens { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
