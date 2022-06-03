using System.Collections.Generic;

namespace PeopleList.Models
{
    public interface IPeopleRepository
    {
        IEnumerable<Person>  AllPeople { get; }
    }
}