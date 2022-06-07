using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PeopleIndex.Models
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
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<PeopleWhoSpeakLanguage> PeopleWhoSpeakLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                        
           /* modelBuilder.Entity<PeopleWhoSpeakLanguage>().HasKey(pwsl => new { pwsl.Id, pwsl.LanguageId });

            modelBuilder.Entity<PeopleWhoSpeakLanguage>()
                .HasOne(pwsl => pwsl.Language)
                .WithMany(p => p.WhoSpeakLanguages)
                .HasForeignKey(pwsl => pwsl.LanguageId);

            modelBuilder.Entity<PeopleWhoSpeakLanguage>()
                .HasOne(pwsl => pwsl.People)
                .WithMany(l => l.LanguageOfPerson)
                .HasForeignKey(pwsl => pwsl.Id);*/
                
            // seed Countries

            modelBuilder.Entity<Country>().HasData(new Country
            {
                CountryId = 1,
                CountryName = "Sweden"
            });
            modelBuilder.Entity<Country>().HasData(new Country
            {
                CountryId = 2,
                CountryName = "Denmark"
            });
            modelBuilder.Entity<Country>().HasData(new Country
            {
                CountryId = 3,
                CountryName = "Norway"
            });

            //seed Cities

            modelBuilder.Entity<City>().HasData(new City
            {
                CityId = 1,
                CityName = "Stockholm",
                CountryId = 1
            });
            modelBuilder.Entity<City>().HasData(new City
            {
                CityId = 2,
                CityName = "Göteborg",
                CountryId = 1
            });
            modelBuilder.Entity<City>().HasData(new City
            {
                CityId = 3,
                CityName = "Malmö",
                CountryId = 1
            });
            modelBuilder.Entity<City>().HasData(new City
            {
                CityId = 4,
                CityName = "Halmstad",
                CountryId = 1
            });

            //seed People

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1,
                Name = "Christian",
                PhoneNumber = "0123456789",
                CityId=4
            }) ;

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 2,
                Name = "Billy",
                PhoneNumber = "1234567890",
                CityId=4
            });

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 3,
                Name = "Adam",
                PhoneNumber = "3456789012",
                CityId=1
            });

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 4,
                Name = "Dennis",
                PhoneNumber = "3478956012",
                CityId=2
            });

        }

    }
}
