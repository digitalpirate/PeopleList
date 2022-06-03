using PeopleList.Models;
using System.Collections.Generic;


namespace PeopleList.ViewModels
{
    public class PeopleViewModel
    {
        public IEnumerable<Person> Person { get; set; }
    }
}
