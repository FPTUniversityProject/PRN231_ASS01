using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObject
{
    public class Assignment01DbContext : DbContext
    {
        public Assignment01DbContext() { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configurationRoot = builder.Build();
            var connectionString = configurationRoot.GetConnectionString("Assign01ConStr");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category { CategoryId = 1, CategoryName = "Beverages" },
                 new Category { CategoryId = 2, CategoryName = "Condiments" },
                 new Category { CategoryId = 3, CategoryName = "Cofections" },
                 new Category { CategoryId = 4, CategoryName = "Dairy Products" },
                 new Category { CategoryId = 5, CategoryName = "Grains/Cereals" },
                 new Category { CategoryId = 6, CategoryName = "Meat/Poultry" },
                 new Category { CategoryId = 7, CategoryName = "Produce" },
                 new Category { CategoryId = 8, CategoryName = "Seafood" }
             );

            modelBuilder.Entity<Product>().HasData(
               new Product { ProductId = 1, CategoryId = 1, ProductName = "Product 1", UnitPrice = 20000, UnitsInStock = 100 },
               new Product { ProductId = 2, CategoryId = 2, ProductName = "Product 2", UnitPrice = 30000, UnitsInStock = 100 },
               new Product { ProductId = 3, CategoryId = 3, ProductName = "Product 3", UnitPrice = 40000, UnitsInStock = 100 },
               new Product { ProductId = 4, CategoryId = 4, ProductName = "Product 4", UnitPrice = 50000, UnitsInStock = 100 },
               new Product { ProductId = 5, CategoryId = 5, ProductName = "Product 5", UnitPrice = 60000, UnitsInStock = 100 },
               new Product { ProductId = 6, CategoryId = 6, ProductName = "Product 6", UnitPrice = 70000, UnitsInStock = 100 },
               new Product { ProductId = 7, CategoryId = 7, ProductName = "Product 7", UnitPrice = 80000, UnitsInStock = 100 },
               new Product { ProductId = 8, CategoryId = 8, ProductName = "Product 8", UnitPrice = 90000, UnitsInStock = 100 }
           );
        }
    }
}
