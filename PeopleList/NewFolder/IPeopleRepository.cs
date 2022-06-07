using PeopleIndex.Models;
using System.Collections.Generic;

namespace PeopleIndex.NewFolder
{
    public interface IPeopleRepository
    {
        IEnumerable<Person> AllPeople { get; }
    }
}