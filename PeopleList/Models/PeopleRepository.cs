
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleList.Models
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly AppDbContext _appDbContext;
        public PeopleRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Person> AllPeople
        {
            get { return _appDbContext.People; }
        }


        /*public IEnumerable<Person> AllPeople =>
            new List<Person>
            {
                new Person{
        Id=1, 
        Name ="Christian", 
        PhoneNumber="0123456789", 
        City="Halmstad"},
                new Person{Id=2, Name ="Billy", PhoneNumber="9876543210", City="Stad"},
                new Person{Id=3, Name ="Bolly", PhoneNumber="9876543210", City="Stad"},
                new Person{Id=4, Name ="Person2", PhoneNumber ="5478963210", City="City"}
            };*/
    }
}
