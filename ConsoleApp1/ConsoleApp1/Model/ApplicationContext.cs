using Microsoft.EntityFrameworkCore;
using ConsoleApp1.Model.DatabaseModels;

namespace ConsoleApp1.Model
{
    internal class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BookstoreChain;Trusted_Connection=True;");
        }

        public virtual DbSet<SPResult> SpResults { get; set; }

        #region Properties
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;
        public DbSet<SaleRegistration> SaleRegistations { get; set; } = null!;
        public DbSet<Store> Stores { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        #endregion
    }
}
