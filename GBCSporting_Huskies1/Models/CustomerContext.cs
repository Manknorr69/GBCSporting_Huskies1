using Microsoft.EntityFrameworkCore;
namespace GBCSporting_Huskies1.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
              : base(options) { }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Catergory> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catergory>().HasData(
                new Catergory { CategoryId = 1, Name = "China" },
                new Catergory { CategoryId = 2, Name = "Canada" },
                new Catergory { CategoryId = 3, Name = "Russia" },
                new Catergory { CategoryId = 4, Name = "United States" },
                new Catergory { CategoryId = 5, Name = "United Kingdom" },
                new Catergory { CategoryId = 6, Name = "Zimbabwe" }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Firstname = "Pepe",
                    Lastname = "The Clown",
                    Address = "553 Emerson Drive",
                    City = "Gotham",
                    State = "Washington",
                    Postalcode = "T6R 3F7",
                    DateAdded = DateTime.Now,
                    CategoryId = 1,
                    Email = "something@yahoo.com",
                    Phone = "5567921312"


                }
               );
        }

    }
}
