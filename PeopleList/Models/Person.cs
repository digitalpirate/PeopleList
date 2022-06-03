using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleList.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }

        public void AddNewPerson(int Id,string name, string phoneNumber, string city)
        {
            //Hämta ut högsta Id från databas, öka med ett. Sätt som Id nedan och ta bort inmatning av Id manuellt

            using (var context = new AppDbContext())
            {
                var newPerson = new Person()
                {
                    Id = Id,
                    Name = name,
                    PhoneNumber = phoneNumber,
                    City = city
                };
                context.People.Add(newPerson);
                context.SaveChanges();
            }
        }
        public void DeletePerson(int id)
        {
            var person = new Person()
            {
                Id = id
            };

            using (var context = new AppDbContext())
            {
                context.People.Remove(person);
                context.SaveChanges();
            }

        }
        public Person Search(string searchQuery)
        {
            //hämta ut alla objekt som matchar searchQuery och skicka tillbaka
            return null;

        }

    }
    
}
