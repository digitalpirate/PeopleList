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
        public DbSet<CitiesInCountry> CitiesInCountries { get; set; }
        public DbSet<PeopleInCity> PeopleInCities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CitiesInCountry>().HasKey(cic => new { cic.CityId, cic.CountryId });

            modelBuilder.Entity<CitiesInCountry>()
                .HasOne(cic => cic.Country)
                .WithMany(ci => ci.Cities)
                .HasForeignKey(cic => cic.CityId);

            modelBuilder.Entity<PeopleInCity>().HasKey(pic => new { pic.Id, pic.CityId });

            modelBuilder.Entity<PeopleInCity>()
                .HasOne(pic => pic.City)
                .WithMany(p => p.People)
                .HasForeignKey(pic => pic.CityId);

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
                CityName = "Stockholm"
            });
            modelBuilder.Entity<City>().HasData(new City
            {
                CityId = 2,
                CityName = "Göteborg"
            });
            modelBuilder.Entity<City>().HasData(new City
            {
                CityId = 3,
                CityName = "Malmö"
            });

            //seed People

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1,
                Name = "Christian",
                PhoneNumber = "0123456789",
                City = "Halmstad"
            }) ;

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
