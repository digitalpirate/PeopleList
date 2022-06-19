﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PeopleIndex.Models
{
    public class AppDbContext : IdentityDbContext
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
        public DbSet<Language> Languages { get; set; }
        public DbSet<PersonLanguage> Personlanguage { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
                        
            modelBuilder.Entity<PersonLanguage>().HasKey(pwsl => new { pwsl.PersonId, pwsl.LanguageId });

            modelBuilder.Entity<PersonLanguage>()
                .HasOne(pwsl => pwsl.Language)
                .WithMany(p => p.PersonLanguage)
                .HasForeignKey(pwsl => pwsl.PersonId);

            modelBuilder.Entity<PersonLanguage>()
                .HasOne(pwsl => pwsl.Person)
                .WithMany(l => l.PersonLanguage)
                .HasForeignKey(pwsl => pwsl.LanguageId);

            //seed Language

            modelBuilder.Entity<Language>().HasData(new Language
            {
                LanguageId = 1,
                LanguageName = "Swedish"
            });

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
                PersonId = 1,
                Name = "Christian",
                PhoneNumber = "0123456789",
                CityId=4
            }) ;

            modelBuilder.Entity<Person>().HasData(new Person
            {
                PersonId = 2,
                Name = "Billy",
                PhoneNumber = "1234567890",
                CityId=4
            });

            modelBuilder.Entity<Person>().HasData(new Person
            {
                PersonId = 3,
                Name = "Adam",
                PhoneNumber = "3456789012",
                CityId=1
            });

            modelBuilder.Entity<Person>().HasData(new Person
            {
                PersonId = 4,
                Name = "Dennis",
                PhoneNumber = "3478956012",
                CityId=2
            });

        }

    }
}
