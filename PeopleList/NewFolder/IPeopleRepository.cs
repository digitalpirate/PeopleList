using PeopleList.Models;
using System.Collections.Generic;

namespace PeopleList.NewFolder
{
    public interface IPeopleRepository
    {
        IEnumerable<Person> AllPeople { get; }
    }
}