using Microsoft.EntityFrameworkCore;
using ConsoleApp1.Model.DatabaseModels;

namespace ConsoleApp1.Model
{
    internal class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BookstoreChain;Trusted_Connection=True;");
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country>  Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<SaleRegistration> SaleRegistations { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
