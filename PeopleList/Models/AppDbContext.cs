using Microsoft.EntityFrameworkCore;

namespace PeopleList.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                        
            //seed database

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1,
                Name = "Christian",
                PhoneNumber = "0123456789",
                City = "Halmstad"
            });

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 2,
                Name = "Billy",
                PhoneNumber = "1234567890",
                City = "Halmstad"
            });

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 3,
                Name = "Adam",
                PhoneNumber = "3456789012",
                City = "Stockholm"
            });

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 4,
                Name = "Dennis",
                PhoneNumber = "3478956012",
                City = "Göteborg"
            });

        }

    }
}
